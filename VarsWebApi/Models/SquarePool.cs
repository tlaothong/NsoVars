using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class SquarePool : ModelBase
    {
        /// <summary>
        /// ความกว้าง
        /// </summary>
        /// <value></value>
        public int Width { get; set; }

        /// <summary>
        /// ความยาว
        /// </summary>
        /// <value></value>
        public int Length { get; set; }

        /// <summary>
        /// ความลึก
        /// </summary>
        /// <value></value>
        public int Depth { get; set; }
    }
}