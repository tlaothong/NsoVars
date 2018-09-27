﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class DetailManagementForFarming
    {
        /// <summary>
        ///  หาก “มี” มีกี่โครงการ
        /// </summary>
        public int ManagementForFarmingCount { get; set; }

        /// <summary>
        /// ชื่อโครงการ
        /// </summary>
        public string NameOfManagement { get; set; }

        /// <summary>
        /// พื้นที่ของโครงการมีกี่ไร่ ใช้ ไร่(Area->Rai) ตารางวา(Area-> SqWa)
        /// </summary>
        public FieldSize ProjectArea { get; set; }

        /// <summary>
        ///  จำนวนครัวเรือนที่เป็นสมาชิกโครงการมีจำนวนเท่าไร 
        /// </summary>
        public int HouseMember { get; set; }

        /// <summary>
        ///  โครงการใช้น้้าผิวดินปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ) 
        /// </summary>
        public int UpperGroundAVGPerMount { get; set; }

        /// <summary>
        ///   โครงการมีบ่อน้้าบาดาลจำนวนกี่บ่อ  
        /// </summary>
        public int UnderGroundOfCount { get; set; }

        /// <summary>
        ///   โครงการใช้น้้าบาดาลปริมาณโดยเฉลี่ยเดือนละเท่าไร (ให้รวมทุกพื้นที่ของโครงการ)  
        /// </summary>
        public int UnderGroundAVGPerMount { get; set; }
    }
}