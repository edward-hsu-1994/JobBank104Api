using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 希望求職者狀態
    /// </summary>
    public enum JobRoleStatus {
        /// <summary>
        /// 上班族
        /// </summary>
        OfficeWorker = 1,
        /// <summary>
        /// 應屆畢業
        /// </summary>
        Graduates = 2,
        /// <summary>
        /// 日間部學生
        /// </summary>
        StudentsAtDay = 4,
        /// <summary>
        /// 夜間部學生
        /// </summary>
        StudentsAtNight = 8,
        /// <summary>
        /// 國防役
        /// </summary>
        NationalDefenseService = 16,
        /// <summary>
        /// 外籍人數
        /// </summary>
        ForeignNationals = 32,
        /// <summary>
        /// 原住民
        /// </summary>
        IndigenousPeoples = 64,
        /// <summary>
        /// 派遣
        /// </summary>
        Dispatch = 128,
        /// <summary>
        /// 再度就業
        /// </summary>
        Reemployment = 256
    }
}
