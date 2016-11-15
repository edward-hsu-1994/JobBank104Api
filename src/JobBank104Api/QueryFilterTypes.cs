using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api{
    public enum QueryFilterTypes{
        /// <summary>
        /// 不拘
        /// </summary>
        Informal,
        /// <summary>
        /// 僅搜尋
        /// </summary>
        Only,
        /// <summary>
        /// 除外
        /// </summary>
        Without
    }
}
