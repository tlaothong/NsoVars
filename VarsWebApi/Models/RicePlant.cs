﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models {
    /// <summary>
    /// ข้าว
    /// </summary>
    public class RicePlant {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกข้าวเองหรือไม่
        /// </summary>
        public bool Doing { get; set; }

        /// <summary>
        ///  “ปลูกข้าว” มีแปลงนาจ้านวนกี่แปลง
        /// </summary>
        public int FieldCount { get; set; }

        /// <summary>
        /// ตั้งอยู่ที่ใด (จังหวัด อำเภอ ตำบล)
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// ขนาดพื้นที่เท่าไร กี่ไร่ กี่งาน กี่ตางรางวา
        /// </summary>
        public Area Area { get; set; }
    }
}