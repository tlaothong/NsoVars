using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class UserInfo
    {
        // TODO: Name
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