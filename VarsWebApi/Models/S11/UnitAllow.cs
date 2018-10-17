using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class UnitAllow
    {
        /// <summary>
        /// 1 มีผู้ให้ข้อมูล และให้ความร่วมมือ 
        /// 2 มีผู้ให้ข้อมูล แต่ไม่ให้ความรว่มมอื 
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล    
        /// 4 ห้อง/บ้าน/อาคาร ว่าง   
        /// 5 ห้อง/บ้าน/อาคาร ร้าง
        /// </summary>
        public UnitAllowed MyProperty { get; set; }
        /// <summary>
        /// ใช้น้้าประปาหรอืไม่ 1.ใช้ 2.ไม่ใช้ 
        /// </summary>
        public bool PlumbingUsage { get; set; }
        /// <summary>
        /// มีมิเตอรน์้้าประปา แยกจากส่วนกลาง หรือไม่ 1.มี 2.ไม่มี 
        /// </summary>
        public bool HasPrivatePlumbingMeter { get; set; }
        /// <summary>
        /// ถ้ามี เปน็มิเตอรข์อง การประปาส่วน ภูมิภาค/ นครหลวงใช่ หรือไม่ 1.ใช ่   2.ไม่ใช่ 
        /// </summary>
        public bool? MWAOrPWA{ get; set; }
        /// <summary>
        /// ใช้น้้าบาดาลหรือไม่ 1.ใช้ 2.ไม่ใช้
        /// </summary>
        public bool HasGroundWater { get; set; }
        /// <summary>
        /// มีมิเตอรน์้้าบาดาล แยกจากส่วนกลาง หรือไม่ 1.มี 2.ไม่มี 
        /// </summary>
        public bool PrivateGroundWaterMeter { get; set; }
        /// <summary>
        /// ให้บันทึกขอ้ความเกี่ยวกับ ปัญหา/ อุปสรรค/การนัดหมาย/ เหตุผลทนี่ับจดไม่ได้ 
        /// </summary>
        public string Problem { get; set; }
        /// <summary>
        /// สถานที่นี้มีผู้อยู่อาศัยติดต่อกันนานเกิน 3 เดือนใช่หรือไม่ 
        /// </summary>
        public bool HasPerson { get; set; }
        /// <summary>
        /// ผู้ที่อาศัยอยู่ในสถานที่นี้มีพื้นที่ปลกูพืช  เลี้ยงสัตว์หรือท้าการเกษตรเองใช่หรือไม่ 
        /// </summary>
        public bool Agriculture { get; set; }
        /// <summary>
        /// สถานที่นี้ใช้เพื่อท้าการผลิตใช่หรือไม่ 
        /// </summary>
        public bool Factorial { get; set; }
        /// <summary>
        /// สถานที่นี้ใช้เพื่อท้าการบริการใช่หรือไม่ 
        /// </summary>
        public bool Commercial { get; set; }
    }
}