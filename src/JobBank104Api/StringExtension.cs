using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    public static class StringExtension {
        public static string InnerString(this string obj,string start,string end) {
            var result = obj;
            result = result.Substring(result.IndexOf(start) + start.Length);
            return result.Substring(0,result.IndexOf(end));
        }
    }
}
