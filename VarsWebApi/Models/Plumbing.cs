sing System;
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
    }
}