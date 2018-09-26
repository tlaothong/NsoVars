using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ำประปา 
    /// </summary>
    public class Plumbing : ModelBase
    {
        /// <summary>
        ///  น้้าประปานครหลวง
        /// </summary>
        public bool MWA { get; set; }

        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        public WaterQuality WaterQualityMWA { get; set; }



        /// <summary>
        ///  น้้าประปาส่วนภูมิภาค 
        /// </summary>
        public bool PWA { get; set; }
        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        public WaterQuality WaterQualityPWA { get; set; }



        /// <summary>
        ///  น้้าประปาอื่น ๆ (หมู่บ้าน,อบต.,เทศบาล,ชุมชน, นิคม, ภูเขา, ฯลฯ)  
        /// </summary>
        public bool Other { get; set; }
        /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        public WaterQuality WaterQualityOther { get; set; }


        /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร   
        /// </summary>
        public int WaterActivity { get; set; }
        /// <summary>
        ///   ในรอบ 12 เดือนที่ผ่านมา มีเหตุการณ์ที่น้ำประปาไม่ไหล ติดต่อกันเกิน 3 วันหรือไม่   
        /// </summary>
        public bool WaterNotRunning { get; set; }

       




    }
}