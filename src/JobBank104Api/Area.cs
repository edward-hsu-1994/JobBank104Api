using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace JobBank104Api {
    public class Area {
        [JsonProperty("no")]
        public string Id { get; set; }

        [JsonProperty("des")]
        public string Name { get; set; }

        [JsonProperty("n")]
        public Area[] SubAreas { get; set; }
                
        public List<Area> FindAreas(Func<Area,bool> func) {
            List<Area> result = new List<Area>();
            if (func(this)) {
                result.Add(this);
            }
            if (SubAreas == null) return result;
            foreach(var area in SubAreas) {
                result.AddRange(area.FindAreas(func));
            }
            return result;
        }

        public static async Task<Area> GetRootArea() {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync("https://www.104.com.tw/public/function01/utf8/jsonArea.js");
            response = response.InnerString("var jsonAreaRoot='{\"n\":", "}';");
            return new Area() {
                Id = null,
                Name = "root",
                SubAreas = JsonConvert.DeserializeObject<Area[]>(response)
            };
        }
    }
}
