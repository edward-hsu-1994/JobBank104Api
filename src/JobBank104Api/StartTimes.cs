using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    public enum StartTimes {
        /// <summary>
        /// 不拘
        /// </summary>
        Informal = 3,
        /// <summary>
        /// 即時
        /// </summary>
        AnyTime = 3,
        /// <summary>
        /// 兩週內
        /// </summary>
        TwoWeeks = 1,
        /// <summary>
        /// 一個月內
        /// </summary>
        OneMonth = 2
    }
}
