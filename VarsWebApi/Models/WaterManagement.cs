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
        public int CountWaterSupply { get; set; }

        /// <summary>
        /// ชื่อของแหล่งน้ำ
        /// </summary>
        public string WaterSupplyName { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าน้้าประปา
        /// </summary>
        public bool UseWaterForPlumbing { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าการผลิต/อุตสาหกรรม 
        /// </summary>
        public bool UseWaterForFactory { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการเกษตร 
        /// </summary>
        public bool UseWaterForFarming { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการบริการ 
        /// </summary>
        public bool UseWaterForService { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการบริการ 
        /// </summary>
        public string UseWaterForOther { get; set; }

        /// <summary>
        /// ขนาดของแหล่งน้้า
        /// </summary>
        public Area Area { get; set; }
        // TODO:
        /// <summary>
        /// ถ้าแหล่งน้้าเป็นสี่เหลี่ยม กว้าง ยาว ลึกเท่าไร 
        /// </summary>
        public SquarePool SquarePool { get; set; }

        /// <summary>
        ///  ถ้าแหล่งน้้าเป็นวงกลม เส้นผ่านศูนย์กลางกี่ เมตร ลึกเท่าไร 
        /// </summary>
        public Circle Circle { get; set; }

        /// <summary>
        ///  ในหมู่บ้าน/ชุมชนนี้มีระบบน้้าประปาประเภทใดบ้าง 
        /// </summary>
        public bool PWA { get; set; }

        /// <summary>
        ///   น้้าประปานครหลวง 
        /// </summary>
        public bool MWA { get; set; }

        /// <summary>
        ///   น้้าประปาอื่นๆ 
        /// </summary>
        public string Other { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชน เป็นที่ตั้งของแหล่งผลิตน้้าประปาอื่นๆ (หมู่บ้าน, อบต., เทศบาล, ชุมชน, นิคม, ภูเขา, ฯลฯ)  ใช่หรือไม่ 
        /// </summary>
        public bool OrgWaterSupply { get; set; }

        /// <summary>
        /// หาก “ใช่” ในหมู่บ้าน/ชุมชน มีแหล่งผลิตน้้าประปาอื่นๆ กี่หน่วยงาน 
        /// </summary>
        public int CountOrgWaterSupply { get; set; }

        /// <summary>
        /// ชื่อหน่วยงาน 
        /// </summary>
        public string NameOrgWaterSupply { get; set; }


        /// <summary>
        /// ใช้น้้าผิวดิน (สระน้้า แม่น้้า/ล้าคลอง) หรือไม่ถ้า “ใช้” ใช้น้้าผิวดินผลิตน้้าประปาโดยเฉลี่ยต่อเดือน ปริมาณเท่าไร 
        /// </summary>
        public int CapacityGroundWater { get; set; }

        /// <summary>
        ///  ใช้น้้าจาก บ่อบาดาล หรือไม่ ถ้า “ใช้” ใช้น้้าจากบ่อบาดาลกี่บ่อ ใช้น้้าบาดาลผลิตน้้าประปาโดยเฉลี่ยต่อเดือนปริมาณเท่าไร  
        /// </summary>
        public int CountUnderGround { get; set; }

        /// <summary>
        ///  ใช้น้้าจาก บ่อบาดาล หรือไม่ ถ้า “ใช้” ใช้น้้าจากบ่อบาดาลกี่บ่อ ใช้น้้าบาดาลผลิตน้้าประปาโดยเฉลี่ยต่อเดือนปริมาณเท่าไร  
        /// </summary>
        public int CapacityUnderGround { get; set; }

        /// <summary>
        /// น้้าประปาราคาขายหน่วยละเท่าไร 
        /// </summary>
        public int PlumbingPrice { get; set; }

        /// <summary>
        ///  ค่าเช่ามิเตอร์คิดเดือนละเท่าไร  
        /// </summary>
        public int ForrentMeter { get; set; }

        /// <summary>
        ///  การผลิตน้้าประปา มีระบบการฆ่าเชื้อโรคหรือไม่ 
        /// </summary>
        public string Disinfection { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชนมีระบบบ้าบัดน้้าเสียหรือไม่  (ให้กา  ใน  เพียงข้อเดียว) 
        /// </summary>
        public bool WaterTreatment { get; set; }

        /// <summary>
        /// ในช่วงเวลา 5 ปีที่ผ่านมา หมู่บ้าน/ชุมชนแห่งนี้เคยเกิดภัยธรรมชาติหรือไม่  
        /// </summary>
        public string[] DisasterInfiveyear { get; set; }

        /// <summary>
        /// ในหมู่บ้าน/ชุมชนแห่งนี้มีการเตือนภัยและมาตรการช่วยเหลือน้้าท่วมหรือไม่  
        /// </summary>
        public string[] Havedisaster { get; set; }

        /// <summary>
        /// โครงการจัดการน้้าเพื่อการเกษตรชุมชน  โดยใช้พื้นที่สาธารณะ
        /// </summary>
        public ManagementForFarming ManagementForFarming { get; set; }


    }
}
