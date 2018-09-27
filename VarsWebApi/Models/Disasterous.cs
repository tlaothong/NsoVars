using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ปัญหาอุทกภัย
    /// </summary>
    // TODO: go
    public class Disasterous:ModelBase
    {
        /// <summary>
        /// ในรอบ 5 ปีที่ผ่านมา (2556-2560) ที่อยู่อาศัยนี้ประสบปัญหาอุทกภัย (น้ำท่วมขัง น้ำรอการระบาย) หรือไม่
        /// </summary>
        public bool Flooded { get; set; }

        /// <summary>
        /// ปีที่เกิดอุทกภัย 2556-2560
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// FloodAmount - จำนวนครั้งที่เกิดอุทกภัย
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนวัน)
        /// </summary>
        public int DayCount { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนชั่วโมง)
        /// </summary>
        public int HourCount { get; set; }

        /// <summary>
        /// ระดับความสูงของน้ำท่วม (ซม.)
        /// </summary>
        public double Height { get; set; }
    }
}
