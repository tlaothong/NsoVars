using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models {
    /// <summary>
    /// อาคาร / สิ่งปลูกสร้าง
    /// </summary>
    public class AgronomyPlant : ModelBase {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกข้าวเองหรือไม่
        /// </summary>
        public bool Doing { get; set; }
        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตางรางวา
        /// </summary>
        public Area Area { get; set; }
    }
}