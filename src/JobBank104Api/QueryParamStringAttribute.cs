using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    public class QueryParamStringAttribute : Attribute {
        public string Value { get; set; }
    }
}
