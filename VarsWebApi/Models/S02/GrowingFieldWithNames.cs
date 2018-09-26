using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ข้อมูลแปลงเพาะปลูกพืช ที่ระบุชนิดพืชที่ปลูกด้วย
    /// </summary>
    public class GrowingFieldWithNames : GrowingField
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาที่แปลงนี้ปลูกพืช ชนิดใด (ระบุได้ไม่เกิน 5 ชนิด) 
        /// </summary>
        public string[] Names { get; set; }
    }
}
