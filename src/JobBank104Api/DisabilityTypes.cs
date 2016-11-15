using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBank104Api {
    /// <summary>
    /// 身障類別
    /// </summary>
    public enum DisabilityTypes {
        /// <summary>
        /// 不拘
        /// </summary>
        Informal,
        /// <summary>
        /// 視覺
        /// </summary>
        Visual,
        /// <summary>
        /// 聽覺或平衡
        /// </summary>
        HearingOrBalancing,
        /// <summary>
        /// 自閉症
        /// </summary>
        Autism,
        /// <summary>
        /// 慢性精神病
        /// </summary>
        ChronicPsychosis,
        /// <summary>
        /// 上肢
        /// </summary>
        UpperLimbs,
        /// <summary>
        /// 下肢
        /// </summary>
        LowerLimbs,
        /// <summary>
        /// 軀幹
        /// </summary>
        Torso,
        /// <summary>
        /// 聲音或語言
        /// </summary>
        SoundOrLang,
        /// <summary>
        /// 顏面
        /// </summary>
        Face,
        /// <summary>
        /// 其他
        /// </summary>
        Other
    }
}
