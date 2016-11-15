using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 關鍵字查詢範圍
    /// </summary>
    public enum QueryKeywordScopes {
        /// <summary>
        /// 職務名稱
        /// </summary>
        JobName = 1,
        /// <summary>
        /// 職務名稱，職務說明，公司名，公司產品，公司簡介，福利制度，產業別描述，擅長工具描述，工作技能描述
        /// </summary>
        JobNameAndComInfo,
        /// <summary>
        /// 職務名稱，職務說明，公司簡介，產業別描述，職務其他描述，職務類別描述，職務產業別描述
        /// </summary>
        JobNameAndTypeInfo,
        /// <summary>
        /// 全文搜索
        /// </summary>
        All
    }
}
