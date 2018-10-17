using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Access
    {
        /// <summary>
        /// 1 มีผู้ให้ข้อมูลให้ความร่วมมือ              
        /// 2 มีผู้ให้ข้อมลูแต่ไม่ให้ความร่วมมือ
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล 
        /// 4 บ้าน/อาคาร ว่างหรือร้าง 
        /// </summary>
        public AccessInfo AccessInfo { get; set; }
        /// <summary>
        /// จำนวนบ้านว่าง 
        /// </summary>
        public int? EmptyHouse { get; set; }
        /// <summary>
        /// จำนวนบ้านร้าง
        /// </summary>
        public int? AbandonedHouse { get; set; }

        /// <summary>
        /// จำนวนครัวเรือน/สถานประกอบการรวมทั้งหมดในบ้าน/อาคาร/สิ่งปลูกสร้าง 
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