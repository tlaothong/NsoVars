using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Package
    {
        /// <summary>
        /// ชนิดของบรรจภุัณฑ์ 
        /// </summary>
        // TODO:
        public string PackageName { get; set; }

        /// <summary>
        /// ขนาดของภาชนะ 
        /// </summary>
        public double PackageSize { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่ออุปโภคบริโภค  
        /// </summary>
        public int Consume { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อทำเกษตร 
        /// </summary>        
        public int Agriculture { get; set; }
        
        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อผลิตสินค้า  
        /// </summary>
        public int Factorial { get; set; }

        /// <summary>
        /// จำนวนที่ซื้อต่อเดือน เพื่อการบริการ
        /// </summary>
        public int Commercial { get; set; }
    }
}