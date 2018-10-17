using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Unit
    {
        /// <summary>
        /// ล้าดับที่บ้าน/อาคาร/สิ่งปลูกสร้าง
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// ลำดับครัวเรือน/สถานประกอบการในอาคาร 
        /// </summary>
        public int RankHouse { get; set; }
        /// <summary>
        /// หมายเลขห้อง
        /// </summary>
        public int RoomNumber { get; set; }

        /// <summary>
        /// พบยูนิตย่อย
        /// 1 มีผู้ให้ข้อมูลและให้ความร่วมมือ 
        /// 2 มีผู้ให้ข้อมูลแต่ไม่ให้ความรว่มมอื 
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล    
        /// 4 ห้อง/บ้าน/อาคารว่าง   
        /// 5 ห้อง/บ้าน/อาคารร้าง
        /// </summary>
        public UnitAllowed UnitAllowed { get; set; }
        /// <summary>
        /// ใช้น้ำประปาหรือไม่
        /// </summary>
        public bool PlumbingUsage { get; set; }
        /// <summary>
        /// มีมิเตอรน้ำประปาแยกจากส่วนกลางหรือไม่ 
        /// </summary>
        public bool HasPrivatePlumbingMeter { get; set; }
        /// <summary>
        /// ถ้ามเป็นมิเตอร์ของการประปาส่วนภูมิภาค/นครหลวงใช่หรือไม่
        /// </summary>
        public bool? MWAOrPWA { get; set; }
        /// <summary>
        /// ใช้น้ำบาดาลหรือไม่
        /// </summary>
        public bool HasGroundWater { get; set; }
        /// <summary>
        /// มีมิเตอร์น้ำบาดาลแยกจากส่วนกลางหรือไม่
        /// </summary>
        public bool PrivateGroundWaterMeter { get; set; }
        /// <summary>
        /// ให้บันทึกข้อความเกี่ยวกับปัญหา/อุปสรรค/การนัดหมาย/เหตุผลที่นับจดไม่ได้ 
        /// </summary>
        public string Problem { get; set; }
        /// <summary>
        /// สถานที่นี้มีผู้อยู่อาศัยติดต่อกันนานเกิน 3 เดือนใช่หรือไม่ 
        /// </summary>
        public bool HasPerson { get; set; }
        /// <summary>
        /// ผู้ที่อาศัยอยู่ในสถานที่นี้มีพื้นที่ปลกูพืชเลี้ยงสัตว์หรือท้าการเกษตรเองใช่หรือไม่ 
        /// </summary>
        public bool Agriculture { get; set; }
        /// <summary>
        /// สถานที่นี้ใช้เพื่อทำการผลิตใช่หรือไม่ 
        /// </summary>
        public bool Factorial { get; set; }
        /// <summary>
        /// สถานที่นี้ใช้เพื่อทำการบริการใช่หรือไม่ 
        /// </summary>
        public bool Commercial { get; set; }
    }
}