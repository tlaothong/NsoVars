using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การจัดการน้้าในหมู่บ้าน/ชุมชน 
    /// </summary>
    public class WaterManagement : ModelBase
    {
        /// <summary>
        /// ในหมู่บ้าน/ชุมชนแห่งนี้มี แหล่งน้้าสาธารณะ (สระน้้า/ หนอง/ บึง/ อ่างเก็บน้้า) หรือไม่ 
        /// </summary>
        public bool WaterSupplyPublic { get; set; }

        /// <summary>
        /// หาก “มี” มีจ้านวนกี่แหล่ง
        /// </summary>
        public int WaterSupplyCount { get; set; }

        /// <summary>
        /// รายละเอียดของแหล่งน้ำสาธารณะ 
        /// </summary>
        public List<DetailWaterManagement> DetailWaterManagement { get; set; }


        /// <summary>
        ///  น้้าประปาส่วนภูมิภาค  
        /// </summary>
        public bool PWA { get; set; }

        /// <summary>
        ///   น้้าประปานครหลวง 
        /// </summary>
        public bool MWA { get; set; }

        /// <summary>
        ///   น้้าประปาอื่นๆ 
        /// </summary>
        public bool PlumbingOther { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชน เป็นที่ตั้งของแหล่งผลิตน้้าประปาอื่นๆ (หมู่บ้าน, อบต., เทศบาล, ชุมชน, นิคม, ภูเขา, ฯลฯ)  ใช่หรือไม่ 
        /// </summary>
        public bool OrgWaterSupply { get; set; }

        /// <summary>
        /// หาก “ใช่” ในหมู่บ้าน/ชุมชน มีแหล่งผลิตน้้าประปาอื่นๆ กี่หน่วยงาน 
        /// </summary>
        public int OrgWaterSupplyCount { get; set; }

        /// <summary>
        /// รายละเอียดของหน่วยงานแหล่งผลิตน้ำประปา
        /// </summary>
        public List<DetailOrgWaterSupply> DetailOrgWaterSupply { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชนมีระบบบ้าบัดน้้าเสียหรือไม่  (ให้กา  ใน  เพียงข้อเดียว) 
        /// </summary>
        public bool WaterTreatment { get; set; }


        /// <summary>
        /// ในช่วงเวลา 5 ปีที่ผ่านมา หมู่บ้าน/ชุมชนแห่งนี้เคยเกิดภัยธรรมชาติหรือไม่  
        /// </summary>
        public bool HasDisasterInFiveYear { get; set; }
        /// <summary>
        /// ถ้าเคย ภัยธรรมชาติที่เกิดมีอะไรบ้าง (ให้เลือกได้หลายข้อ) 
        /// </summary>
        public string[] DisasterInFiveYear { get; set; }

        // <summary>
        /// ในหมู่บ้าน/ชุมชนแห่งนี้มีการเตือนภัยและมาตรการช่วยเหลือน้้าท่วมหรือไม่  
        /// </summary>
        public bool HasHaveDisaster { get; set; }
        /// <summary>
        ///  ถ้ามีลักษณะการดำเนินการเป็นอย่างไร (ให้เลือกได้หลายข้อ)   
        /// </summary>
        public string[] HaveDisaster { get; set; }

        /// <summary>
        /// โครงการจัดการน้้าเพื่อการเกษตรชุมชน  โดยใช้พื้นที่สาธารณะ
        /// </summary>
        public ManagementForFarming ManagementForFarming { get; set; }


    }
}
