using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// อาคาร / สิ่งปลูกสร้าง
    /// </summary>
    public class AgronomyPlant : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกข้าวเองหรือไม่
        /// </summary>
        public bool Doing { get; set; }

         /// <summary>
        /// ตั้งอยู่ที่ใด
        /// </summary>
        public Location Location { get; set; }
        
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตางรางวา
        /// </summary>
        public Area Area { get; set; }

        /// <summary>
        /// ที่แปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่
        /// </summary>
        public bool IrrigationField { get; set; }

        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาที่แปลงนี้ปลูกพืชไร่ ชนิดใด (ระบุได้ไมเ่กิน 5 ชนิด) 
        /// </summary>
        public string AgronomyPerYear { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง    (ให้กา  ใน  ได้หลายข้อ) 
        /// </summary>
        public WaterSources WaterSource { get; set; }
    }
}