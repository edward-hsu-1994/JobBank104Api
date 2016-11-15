using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class Indust {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public Indust[] SubIndusts { get; set; }
                
        public List<Indust> FindIndusts(Func<Indust, bool> func) {
            List<Indust> result = new List<Indust>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubIndusts == null) return result;
            foreach(var indust in SubIndusts) {
                result.AddRange(indust.FindIndusts(func));
            }
            return result;
        }

        public static async Task<Indust> GetRootIndust() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.104.com.tw/public/function01/utf8/jsonIndust.js");
            response = response.InnerString("var jsonIndustRoot='{\"n\":", "}';");
            return new Indust() {
                Id = null,
                Name = "root",
                SubIndusts = JsonConvert.DeserializeObject<Indust[]>(response)
            };
        }
    }
}
