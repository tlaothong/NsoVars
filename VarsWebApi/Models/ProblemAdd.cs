using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ข้อมูลแปลงเพาะปลูกพืช ที่ระบุชนิดพืชที่ปลูกด้วย
    /// </summary>
    public class ProblemAdd : Problem
    {
        /// <summary>
        /// ขุ่น/ตะกอน  
        /// </summary>
        public bool TurbidWater { get; set; }

         /// <summary>
        ///  น้ำกระด้าง
        /// </summary>
        public bool HardWater { get; set; }
    }
}
