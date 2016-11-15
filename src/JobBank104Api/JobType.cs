using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class JobType {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public JobType[] SubTypes { get; set; }
                
        public List<JobType> FindTypes(Func<JobType,bool> func) {
            List<JobType> result = new List<JobType>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubTypes == null) return result;
            foreach(var type in SubTypes) {
                result.AddRange(type.FindTypes(func));
            }
            return result;
        }

        public static async Task<JobType> GetRootType() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.104.com.tw/public/function01/utf8/jsonJobCat.js");
            response = response.InnerString("var jsonJobCatRoot='{\"n\":", "}';");
            return new JobType() {
                Id = null,
                Name = "root",
                SubTypes = JsonConvert.DeserializeObject<JobType[]>(response)
            };
        }
    }
}
