using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// พื้นที่วงกลม
    /// </summary>
    public class Circle : ModelBase
    {
        /// <summary>
        /// เส้นผ่านศูนย์กลาง
        /// </summary>
        public int Diameter { get; set; }

        /// <summary>
        /// ความลึก
        /// </summary>
        public int Depth { get; set; }
    }
}