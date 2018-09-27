﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ลักษณะพื้นที่เลี้ยงสัตว์น้ำ
    /// </summary>
    public enum AquariumFieldShape
    {
        /// <summary>
        /// ระบุขนาดพื้นที่ เป็น ไร่ งาน ตารางวา
        /// </summary>
        Area            = 1,
        /// <summary>
        /// เป็นบ่อสี่เหลี่ยม
        /// </summary>
        Rectangle       = 2,
        /// <summary>
        /// เป็นบ่อวงกลม
        /// </summary>
        Circle          = 3
    }
}
