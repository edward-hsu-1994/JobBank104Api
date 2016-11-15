using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class JobSkill {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public JobSkill[] SubJobSkills { get; set; }
                
        public List<JobSkill> FindJobSkills(Func<JobSkill,bool> func) {
            List<JobSkill> result = new List<JobSkill>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubJobSkills == null) return result;
            foreach(var area in SubJobSkills) {
                result.AddRange(area.FindJobSkills(func));
            }
            return result;
        }

        public static async Task<JobSkill> GetRootJobSkill() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("http://www.104.com.tw/public/function01/utf8/jsonAbil.js");
            response = response.InnerString("var jsonAbilRoot='{\"n\":", "}';");
            return new JobSkill() {
                Id = null,
                Name = "root",
                SubJobSkills = JsonConvert.DeserializeObject<JobSkill[]>(response)
            };
        }
    }
}
