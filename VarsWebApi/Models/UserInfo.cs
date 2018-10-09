using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class UserInfo
    {
        /// <summary>
        /// ชื่อผู้ให้ข้อมูล 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการผลิต 
        /// </summary>
        public string[] Category { get; set; }
        /// <summary>
        /// ประเภทสถานประกอบการบริการ 
        /// </summary>
        public string[] ServiceType { get; set; }
    }
}