using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การใช้น้ำ
    /// </summary>
    public class WaterUsage : ModelBase
    {
        /// <summary>
        /// น้ำประปานครหลวง
        /// </summary>
        public bool MWA { get; set; }
        /// <summary>
        /// น้ำประปาส่วนภูมิภาค
        /// </summary>
        public bool PWA { get; set; }
    }
}
