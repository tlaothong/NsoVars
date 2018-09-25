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
        /// <summary>
        /// น้ำจากสระน้ำ/หนองน้ำ/บึง (มีหนองน้ำ บึง สระน้ำส่วนตัว ที่อยู่ในไร่นา พื้นที่อยู่อาศัย สถานประกอบการ)
        /// </summary>
        public Pool Pool { get; set; }
    }
}
