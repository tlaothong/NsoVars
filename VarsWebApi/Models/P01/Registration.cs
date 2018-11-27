using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ความเกี่ยวพันกับหัวหน้าครอบครัว
    /// </summary>
    public enum Registration
    {
        /// <summary>
        /// มีในบ้านนี้
        /// </summary>
        InThisHouse = 1,

        /// <summary>
        /// ไม่มีในบ้านนี้แต่มีในบ้านอื่นในจังหวัดนี้
        /// </summary>
        NoThisHouseButInThisProvince = 2,

        /// <summary>
        /// ไม่มีในบ้านนี้แต่มีในจังหวัดอื่น
        /// </summary>
        NoThisHouseButOtherProvince = 3,

        /// <summary>
        /// ไมมีในประเทศไทย แต่มีในประเทศอื่น
        /// </summary>
        NoInThailand = 4,

        /// <summary>
        /// ไม่มีที่ใดเลย
        /// </summary>
        No = 5
    }
}