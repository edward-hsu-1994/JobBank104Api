using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class ComputerSkill {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public ComputerSkill[] SubComputerSkills { get; set; }
                
        public List<ComputerSkill> FindComputerSkills(Func<ComputerSkill,bool> func) {
            List<ComputerSkill> result = new List<ComputerSkill>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubComputerSkills == null) return result;
            foreach(var area in SubComputerSkills) {
                result.AddRange(area.FindComputerSkills(func));
            }
            return result;
        }

        public static async Task<ComputerSkill> GetRootComputerSkill() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("http://www.104.com.tw/public/function01/utf8/jsonTool.js");
            response = response.InnerString("var jsonToolRoot='{\"n\":", "}';");
            return new ComputerSkill() {
                Id = null,
                Name = "root",
                SubComputerSkills = JsonConvert.DeserializeObject<ComputerSkill[]>(response)
            };
        }
    }
}
