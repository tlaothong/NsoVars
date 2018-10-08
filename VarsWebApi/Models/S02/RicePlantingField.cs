using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models {
    public class RicePlantingField 
    {
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
        public int PlantingCount { get; set; }
        /// <summary>
        ///  แต่ละครั้งท้ากี่ไร่ ท้าทั้งแปลงทุกครั้งหรือไม่ ถ้าใช่เลือก 
        /// </summary>
        /// <remarks>
        ///     1. ทำทั้งแปลงทุกครั้ง
        ///     2. ไม่ได้ทำทั้งแปลง แต่ทำเท่ากันทุกครั้ง (-- พื้นที่เท่ากันทุกครั้ง)
        ///     3. ไม่ได้ทำทั้งแปลง และทำไม่เท่ากันทุกครั้ง
        /// </remarks>
        public PlantingArea PlantingArea { get; set; }
        /// <summary>
        /// พื้นที่เป็น ไร่ งาน ตารางวา ที่ใช้ปลูกในแต่ละครั้ง (ถ้าเลือกข้อ 2 คือ 1 ครั้ง)
        /// </summary>
        public List<Area> AreaUsed { get; set; }
        /// <summary>
        ///   การท้านา เริ่มท้าเดือนใด   
        /// </summary>
        public int PlantingFromMonth { get; set; }
        /// <summary>
        ///   การท้านา ทำถึงเดือนใด   
        /// </summary>
        public int PlantingThruMonth { get; set; }
        /// <summary>
        /// การท้านา ปล่อยน้้าเข้านากี่ครั้ง (ถ้าไม่ได้ปล่อยน้ำให้กรอก 0)
        /// </summary>
        public int WaterFillingCount { get; set; }
        /// <summary>
        /// การท้านา โดยเฉลี่ยแต่ละครั้งปล่อยน้้าสูง กี่ เซนติเมตร
        /// </summary>
        public double WaterHigh { get; set; }
        /// <summary>
        /// นาแปลงนี้ตั้งอยู่ในเขตชลประทานหรือไม่ 
        /// </summary>
        public bool IrrigationField { get; set; }
        /// <summary>
        /// ที่แปลงนี้ใช้น้้าจากแหล่งใดบ้าง  
        /// </summary>
        public WaterSources WaterSources { get; set; }
     }
}