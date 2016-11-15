using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 工作身分類別
    /// </summary>
    public enum JobRoles {
        /// <summary>
        /// 不拘
        /// </summary>
        Informal,
        /// <summary>
        /// 全職
        /// </summary>
        FullTime,
        /// <summary>
        /// 兼職
        /// </summary>
        PartTime,
        /// <summary>
        /// 高階
        /// </summary>
        HigherOrder
    }
}
