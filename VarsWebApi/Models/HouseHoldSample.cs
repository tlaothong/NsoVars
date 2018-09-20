using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ครัวเรือน - หน่วยตัวอย่าง
    /// </summary>
    public class HouseHoldSample : ModelBase
    {
        /// <summary>
        /// ครัวเรือนที่อยู่อาศัย
        /// </summary>
        public Residential Rensidence { get; set; }
    }
}
