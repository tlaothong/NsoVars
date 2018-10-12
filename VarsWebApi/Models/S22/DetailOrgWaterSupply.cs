using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class DetailOrgWaterSupply
    {
        /// <summary>
        /// ชื่อหน่วยงาน 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ใช้น้้าผิวดิน (สระน้้า แม่น้้า/ล้าคลอง) หรือไม่  
        /// </summary>
        public bool HasOnGroundWater { get; set; }
        /// <summary>
        /// ถ้า “ใช้” ใช้น้้าผิวดินผลิตน้้าประปาโดยเฉลี่ยต่อเดือน ปริมาณเท่าไร  
        /// </summary>
        public int OnGroundWaterCapacity { get; set; }
        /// <summary>
        ///  ใช้น้้าจาก บ่อบาดาล หรือไม่   
        /// </summary>
        public bool UseUnderGroundWater { get; set; }
        /// <summary>
        ///  ถ้า “ใช้” ใช้น้้าจากบ่อบาดาลกี่บ่อ   
        /// </summary>
        public int GroundWaterWellCount { get; set; }

        /// <summary>
        ///  ใช้น้้าบาดาลผลิตน้้าประปาโดยเฉลี่ยต่อเดือนปริมาณเท่าไร   
        /// </summary>
        public int UnderGroundWaterUse { get; set; }

        /// <summary>
        /// น้้าประปาราคาขายหน่วยละเท่าไร 
        /// </summary>
        public double PlumbingPrice { get; set; }

        /// <summary>
        ///  ค่าเช่ามิเตอร์คิดเดือนละเท่าไร  
        /// </summary>
        public double MeterRentalFee { get; set; }

        /// <summary>
        ///  การผลิตน้้าประปา มีระบบการฆ่าเชื้อโรคหรือไม่ 
        /// </summary>
        public DisinfectionMethod Disinfection { get; set; }
        /// <summary>
        /// ระบุการฆ่าเชื้อโรคด้วยวิธีอื่นๆ
        /// </summary>
        public string OtherDisinfection { get; set; }
    }
}
