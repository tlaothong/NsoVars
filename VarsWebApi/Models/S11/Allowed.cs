using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Allowed
    {
        /// <summary>
        /// 1 อนุญาต      
        /// 2 ไม่อนุญาต แต่ให้ข้อมูล 
        /// 3 ไม่อนุญาต และไม่ให้ข้อมลู
        /// </summary>
        public Allow Allow { get; set; }
        /// <summary>
        /// จ้านวนห้องว่าง
        /// </summary>
        /// <value></value>
        public int EmptyRoom { get; set; }
        /// <summary>
        /// จำนวนห้องที่มีผู้อาศัย/จำนวนสถานประกอบการ 
        /// </summary>
        /// <value></value>
        public int UseRoom { get; set; }
        /// <summary>
        /// ปริมาณน้้า
        /// </summary>
        public int WaterQuantity { get; set; }
        /// <summary>
        ///  ค่าน้้า 
        /// </summary>
        public int WaterBill { get; set; }
    }
}