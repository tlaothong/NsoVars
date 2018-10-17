using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Access
    {
        /// <summary>
        /// 1 มีผู้ให้ข้อมูล ให้ความร่วมมอื่น              
        /// 2 มีผู้ให้ข้อมลู แต่ไม่ให้ความร่วมมือ
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล 
        /// 4 บ้าน/อาคาร ว่าง หรอืร้าง 
        /// </summary>
        public AccessInfo AccessInfo { get; set; }
        /// <summary>
        /// จำนวน บ้านว่าง 
        /// </summary>
        public int? EmptyHouse { get; set; }
        /// <summary>
        /// จeนวนบ้านร้าง
        /// </summary>
        public int? AbandonedHouse { get; set; }

        /// <summary>
        /// จ้านวนครัวเรอืน / สถานประกอบการรวมทั้งหมด ในบ้าน / อาคาร / สิ่งปลูกสร้าง 
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// ข้อมูล Unit ย่อย
        /// </summary>
        public List<Unit> UnitInfo { get; set; }
        /// <summary>
        /// ปัญหา
        /// </summary>
        public string Problem { get; set; }
    }
}