using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 管理責任
    /// </summary>
    public enum ManagementLevels {
        /// <summary>
        /// 無
        /// </summary>
        None,
        /// <summary>
        /// 4人以下
        /// </summary>
        Mini,
        /// <summary>
        /// 5~8人
        /// </summary>
        Small,
        /// <summary>
        /// 9~12人
        /// </summary>
        Medium,
        /// <summary>
        /// 13人以上
        /// </summary>
        Large,
        /// <summary>
        /// 人數未知
        /// </summary>
        Other
    }
}
