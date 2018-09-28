using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    public class PlumbingInfo
    {
        /// <summary>
        ///  ใช้หรือไม่
        /// </summary>
        public bool Doing { get; set; }
         /// <summary>
        ///  มีปัญหาคุณภาพน้้า หรือไม่ 
        /// </summary>
        // TODO:  
        public bool WaterQuality { get; set; }
        /// <summary>
        ///  มีปัญหา คือ  
        /// </summary>
        public ProblemAdd Problem { get; set; }
        /// <summary>
        ///  ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร 
        /// </summary>
        public PlumbingUsage PlumbingUsage { get; set; }
        
    }
}