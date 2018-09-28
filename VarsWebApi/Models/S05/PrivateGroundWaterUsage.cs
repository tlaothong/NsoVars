using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    // บ่อน้้าบาดาลส่วนตัว 
    /// <summary>
    ///  ในรอบ 1 ปีที่ผ่านมาใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย 
    /// </summary>
    public enum PrivateGroundWaterUsage
    {
        /// <summary>
        /// ทราบปริมาณน้้า 
        /// </summary>
        CubicMeterPerMonth            = 1,
        /// <summary>
        /// ไม่ทราบปริมาณน้้าแต่ทราบค่าน้้า 
        /// </summary>
        WaterBill       = 2,
        /// <summary>
        ///  ไม่ทราบ
        /// </summary>
        Unknow      = 3
      
        
    }
    
}
