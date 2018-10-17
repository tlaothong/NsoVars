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
        /// 2 ไม่อนุญาตแต่ให้ข้อมูล 
        /// 3 ไม่อนุญาตและไม่ให้ข้อมลู
        /// </summary>
        public Allow Allow { get; set; }
        /// <summary>
        /// จ้านวนห้องว่าง
        /// </summary>
        public int VacantRoomCount { get; set; }
        /// <summary>
        /// จำนวนห้องที่มีผู้อาศัย/จำนวนสถานประกอบการ
        /// </summary>
        public int OccupiedRoomCount { get; set; }
        /// <summary>
        /// ปริมาณน้ำ
        /// </summary>
        public int WaterQuantity { get; set; }
        /// <summary>
        ///  ค่าน้ำ
        /// </summary>
        public int WaterBill { get; set; }
    }
}