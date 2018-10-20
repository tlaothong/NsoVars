using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class ClosingInfo
    {
        /// <summary>
        /// ชื่อผู้ให้ข้อมูล 
        /// </summary>
        public string Informer { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการผลิต 
        /// </summary>
        public string FactorialCategoryCode { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการบริการ 
        /// </summary>
        public string ServiceTypeCode { get; set; }
    }
}