using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 查詢結果排序方式
    /// </summary>
    public enum QueryOrders {
        /// <summary>
        /// 相關性
        /// </summary>
        Relevance = 0,
        /// <summary>
        /// 相關性並使用關鍵字加權
        /// </summary>
        Keyword = 1,
        /// <summary>
        /// 最後更新時間
        /// </summary>
        [QueryOrderAsc]
        UpdateTime = 2,
        /// <summary>
        /// 經歷
        /// </summary>
        [QueryOrderAsc]
        [QueryOrderDesc]
        Period = 3,
        /// <summary>
        /// 學歷
        /// </summary>
        [QueryOrderAsc]
        [QueryOrderDesc]
        Education = 4,
        /// <summary>
        /// 地區
        /// </summary>
        [QueryOrderDesc]
        Area = 5,
        /// <summary>
        /// 月薪
        /// </summary>
        [QueryOrderAsc]
        [QueryOrderDesc]
        Salary = 6,
        /// <summary>
        /// 二週內主動應徵人數(熱門)
        /// </summary>
        [QueryOrderAsc]
        [QueryOrderDesc]
        NumberOfApplicants = 7
    }
}
