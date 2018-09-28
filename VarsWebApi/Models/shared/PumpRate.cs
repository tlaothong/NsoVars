using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    public class PumpRate
    {
        /// <summary>
        /// ทราบอัตราการสูบน้ำ (ถ้าไม่ทราบต้องถามข้อ 4.5 - 4.7 ต่อ)
        /// </summary>
        public bool KnowPumpRate { get; set; }
        /// <summary>
        /// มีอัตราการสูบเท่าไร (ลบ.ม./ชม.)
        /// </summary>
        public int PumpRateUsage { get; set; }
    }
}