using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ำบาดาล
    /// </summary>
    public class GroundWater
    {
        // TODO:Doing
        // บ่อน้้าบาดาลส่วนตัว PrivateGroundWater
        /// <summary>
        /// มีบ่อน้้าบาดาลส่วนตัวหรือไม่
        /// </summary>
        public bool PrivateGroundWater { get; set; }

        /// <summary>
        /// ถ้ามีบ่อน้้าบาดาลส่วนตัว มีจ้านวนกี่บ่อ 
        /// </summary>
        public int GroundWaterCount { get; set; }

        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมา มีบ่อน้้าบาดาลที่ใช้อยู่กี่บ่อ 
        /// </summary>
        public int ActiveGroundWaterCount { get; set; }

        // TODO: enum (ใช้ class ร่วมกับคนอื่นด้วยเลยทำ class ของตัวเอง)
        /// <summary>
        /// ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย 
        /// </summary>
        public List<AvgUsageWaterBill> AvgUsageWater { get; set;} 



        // บ่อน้้าบาดาลสาธารณะ PublicGroundWater
        // TODO: 5.2.4, 5.2.5, 5.2.6 Missing
        /// <summary>
        ///  ใช้น้้าจากบ่อน้้าบาดาลสาธารณะหรือไม่ 
        /// </summary>
        public bool PublicGroundWater { get; set; }

        /// <summary>
        ///   ถ้าใช้น้้าบ่อน้้าบาดาลสาธารณะ ใช้จ้านวนกี่บ่อ 
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        ///   ใช้น้้าปริมาณเท่าไรต่อเดือนโดยเฉลี่ย
        /// </summary>
        public List<AvgUsageWater> UsePerMonth { get; set; }
        
    }
}