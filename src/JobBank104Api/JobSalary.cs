using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 薪資查詢條件
    /// </summary>
    public enum JobSalary {
        /// <summary>
        /// 面議
        /// </summary>
        [QueryParamString(Value = "D")]
        Negotiable,
        /// <summary>
        /// 依公司規定
        /// </summary>
        [QueryParamString(Value = "R")]
        Company,
        /// <summary>
        /// 論件計酬
        /// </summary>
        [QueryParamString(Value = "C")]
        PieceOfPayment,
        /// <summary>
        /// 月薪
        /// </summary>
        [QueryParamString(Value = "S")]
        Salary
    }
}
