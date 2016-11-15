using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class Major {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public Major[] SubMajors { get; set; }
                
        public List<Major> FindMajors(Func<Major, bool> func) {
            List<Major> result = new List<Major>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubMajors == null) return result;
            foreach(var area in SubMajors) {
                result.AddRange(area.FindMajors(func));
            }
            return result;
        }

        public static async Task<Major> GetRootMajor() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.104.com.tw/public/function01/utf8/jsonMajor.js");
            response = response.InnerString("var jsonMajorRoot='{\"n\":", "}';");
            return new Major() {
                Id = null,
                Name = "root",
                SubMajors = JsonConvert.DeserializeObject<Major[]>(response)
            };
        }
    }
}
