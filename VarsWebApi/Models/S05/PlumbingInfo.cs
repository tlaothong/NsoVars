using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    public class PlumbingInfo
    {
        /// <summary>
        ///  ใช้หรือไม่
        /// </summary>
        public bool Doing { get; set; }
         /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        // TODO:  
        public bool WaterQuality { get; set; }
        /// <summary>
        ///  มีปัญหา คือ  
        /// </summary>
        public Problem Problem { get; set; }
        /// <summary>
        ///  ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
        /// </summary>
        /// <remarks>
        /// 1.ทราบปริมาณน้้า
        /// 2.ไม่ทราบปริมาณน้้า แต่ทราบค่าน้้า
        /// 3.ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากไม่มีมิเตอร์แยกจากส่วนกลาง
        /// 4.ไม่ทราบปริมาณน้้าและค่าน้้าเนื่องจากได้รับการยกเว้น  
        /// </remarks>
        public WaterQuantity WaterQuantity { get; set; }
        /// <summary>
        /// ปริมาณน้ำ ลบ.ม./เดือน  
        /// </summary>
        public int CubicMeterPerMonth { get; set; }        
        /// <summary>
        /// ทราบค่าน้้า
        /// </summary>
        public int WaterBill { get; set; }
        
    }
}