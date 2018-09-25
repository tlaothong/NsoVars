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
        /// น้ำประปา
        /// </summary>
        public Plumbing Plumbing { get; set; }
        /// <summary>
        /// น้ำบาดาล
        /// </summary>
        public Underground Underground { get; set; }
        /// <summary>
        /// น้ำจากสระน้ำ
        /// </summary>
        public bool Pool { get; set; }
        /// <summary>
        /// น้ำจากแม่น้ำ / ลำคลอง / แหล่งน้ำสาธารณะ
        /// </summary>
        public bool River { get; set; }
        /// <summary>
        /// น้ำจากชลประทาน
        /// </summary>
        public bool Irrigation { get; set; }
        /// <summary>
        /// น้ำฝนที่กักเก็บไว้
        /// </summary>
        public bool Rain { get; set; }
        /// <summary>
        /// น้ำที่ซื้อมาใช้
        /// </summary>
        public bool Buying { get; set; }
        /// <summary>
        /// อื่น ๆ (ระบุ)
        /// </summary>
        public string Other { get; set; }
    }
}
