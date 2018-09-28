using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    /// <summary>
    /// บรรจุภัณ
    /// </summary>
    // TODO: More Info
    public class PackageWater
    {
        /// <summary>
        /// ประเภทของบรรจุภัณ
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// ขนาดของบรรจุภัณ
        /// </summary>
        public double Size { get; set; }
        /// <summary>
        /// จำนวน
        /// </summary>
        public int Count { get; set; }
    }
}