using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ขาดพื้นที่เป็น ไร่ งาน และ ตารางวา
    /// </summary>
    public class Area
    {
        /// <summary>
        /// ไร่
        /// </summary>
        public int Rai { get; set; }
        /// <summary>
        /// งาน
        /// </summary>
        public int Ngan { get; set; }
        /// <summary>
        /// ตารางวา
        /// </summary>
        public int SqWa { get; set; }
    }
}
