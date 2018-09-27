using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
    /// </summary>
    public class PlumbingUsage
    {

        /// <summary>
        /// ทราบปริมาณน้้า 
        /// </summary>
        public bool Doing { get; set; }
        /// <summary>
        /// ปริมาณน้ำ ลบ.ม./เดือน  
        /// </summary>
        public int CubicMeterPerMonth { get; set; }
        /// <summary>
        /// ไม่ทราบปริมาณน้้า แต่ทราบค่าน้้า     
        /// </summary>
        public bool Unknow { get; set; }
        /// <summary>
        /// ทราบค่าน้้า
        /// </summary>
        public int WaterBill { get; set; }
         /// <summary>
        ///  ไม่ทราบปริมาณน้้า และค่าน้้า เนื่องจากไม่มีมิเตอร์แยกจากส่วนกลาง     
        /// </summary>
        public bool UnknowNoMeter { get; set; }
         /// <summary>
        ///  ไม่ทราบปริมาณน้้า และค่าน้้า เนื่องจากได้รับการยกเว้น      
        /// </summary>
        public bool UnknowExcepted { get; set; }

    }
}