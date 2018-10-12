using System.Collections.Generic;

namespace VarsWebApi.Models
{
    public class GroundWaterBase
    {
        /// <summary>
        /// มีบ่อน้้าบาดาลส่วนตัว / สาธารณะ หรือไม่
        /// </summary>
        public bool Doing { get; set; }

        /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมา มีบ่อน้้าบาดาลที่ใช้อยู่กี่บ่อ 
        /// </summary>
        public int ActiveGroundWaterCount { get; set; }

        // TODO: enum (ใช้ class ร่วมกับคนอื่นด้วยเลยทำ class ของตัวเอง)
        /// <summary>
        /// ในรอบ 1 ปีที่ผ่านมา ใช้น้้าปริมาณเท่าไร ต่อเดือนโดยเฉลี่ย 
        /// </summary>
        public List<GroundWaterWell> Wells { get; set; }
    }
}
