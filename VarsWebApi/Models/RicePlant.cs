using System;
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
         /// <summary>
        ///  ในรอบ 12 เดือนที่ผ่านมาใช้พื้นที่นี้ท้านากี่ครั้ง 
        /// </summary>
        public int RicePlantPerYear { get; set; }
         /// <summary>
        ///  แต่ละครั้งท้ากี่ไร่ ท้าทั้งแปลงทุกครั้งหรือไม่ ถ้าใช่เลือก 
        /// </summary>
        public bool CountRicePlant { get; set; }
         /// <summary>
        ///  แต่ละครั้งท้ากี่ไร่ ถ้าไม่ได้ท้าทั้งแปลง แต่ละครั้งท้าเท่ากันหรือไม่ ถ้าใช่เลือก 
        /// </summary>
        public int RicePlantEqual { get; set; }
         /// <summary>
        ///  แต่ละครั้งท้ากี่ไร่ ถ้าไม่ได้ท้าเท่ากันทุกครั้ง เลือก 3.  แต่ละครั้งท้ากี่ไร่ กี่ตารางวา  
        /// </summary>
        public int[] RicePlantNotEqual { get; set; }
         /// <summary>
        ///   การท้านาครั้งที่ 1 เริ่มท้าเดือนใด   
        /// </summary>
        public string RicePlantMonthStart { get; set; }
         /// <summary>
        ///   การท้านาครั้งที่ 1 ทำถึงเดือนใด   
        /// </summary>
        public string RicePlantMonthComplete { get; set; }
          /// <summary>
        ///   การท้านาครั้งที่ 1 ปล่อยน้้าเข้านากี่ครั้ง  
        /// </summary>
        public int CountWater { get; set; }
         /// <summary>
        ///    การท้านาครั้งที่ 1 โดยเฉลี่ยแต่ละครั้งปล่อยน้้าสูง   
        /// </summary>
        public double WaterHigh { get; set; }
         /// <summary>
        /// นาแปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่ 
        /// </summary>
        public bool IrrigationField { get; set; }
         /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง  
        /// </summary>
        public WaterSources WaterSource { get; set; }



    }
}