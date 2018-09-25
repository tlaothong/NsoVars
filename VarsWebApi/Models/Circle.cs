using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Circle : ModelBase
    {
        /// <summary>
        /// เส้นผ่านศูนย์กลาง
        /// </summary>
        /// <value></value>
        public int Diameter { get; set; }

        /// <summary>
        /// ความลึก
        /// </summary>
        /// <value></value>
        public int Depth { get; set; }
    }
}