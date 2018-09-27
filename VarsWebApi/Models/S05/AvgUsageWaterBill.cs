using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย +บิลค่าน้ำ
    /// </summary>
    public class AvgUsageWaterBill: AvgUsageWater
    {
        /// <summary>
        ///  ไม่ทราบ ถามค่าน้้า  
        /// </summary>
        public bool UnknowAskWaterBill { get; set; }
        /// <summary>
        ///  ถามค่าน้้า  
        /// </summary>
        public int WaterBill { get; set; }
        /// <summary>
    }
}    