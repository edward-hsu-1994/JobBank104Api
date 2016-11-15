using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class Certification {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public Certification[] SubCertifications { get; set; }
                
        public List<Certification> FindCertifications(Func<Certification,bool> func) {
            List<Certification> result = new List<Certification>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubCertifications == null) return result;
            foreach(var area in SubCertifications) {
                result.AddRange(area.FindCertifications(func));
            }
            return result;
        }

        public static async Task<Certification> GetRootCertification() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.104.com.tw/public/function01/utf8/jsonSkill.js");
            response = response.InnerString("var jsonSkillRoot='{\"n\":", "}';");
            return new Certification() {
                Id = null,
                Name = "root",
                SubCertifications = JsonConvert.DeserializeObject<Certification[]>(response)
            };
        }
    }
}
