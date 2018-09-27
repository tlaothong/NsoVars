using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// น้ำประปา 
    /// </summary>
    public class Plumbing
    {
        /// <summary>
        ///  น้้าประปานครหลวง
        /// </summary>DoingMWA
        public PlumbingInfo MWA { get; set; }
        /// <summary>
        ///  น้้าประปาส่วนภูมิภาค 
        /// </summary>
        public PlumbingInfo PWA { get; set; }
        /// <summary>
        ///  น้้าประปาอื่น ๆ (หมู่บ้าน,อบต.,เทศบาล,ชุมชน, นิคม, ภูเขา, ฯลฯ)  
        /// </summary>
        // TODO:Name
        public PlumbingInfo Other { get; set; }
        

        // TODO: 
        /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร(น้้ำประปาส่วนภมูิภาค/นครหลวง)   
        /// </summary>
        public int[] WaterActivityMWAPWA { get; set; }
       
        /// <summary>
        /// 1.ใช้เพื่ออุปโภคบริโภค
        /// </summary>
        public int Drink { get; set; }

        /// <summary>
        /// 2.เพื่อรดน้้าพืชในบริเวณที่อยู่อาศัย
        /// </summary>
        public int Plant { get; set; }

        /// <summary>
        /// 3.ใช้เพื่อท้าเกษตร
        /// </summary>
        public int Agriculture { get; set; }

        /// <summary>
        /// 4.เพื่อผลิตสินค้า
        /// </summary>
        public int Product { get; set; }

        /// <summary>
        /// 5.เพื่อการบริการ
        /// </summary>
        public int Service { get; set; }



         /// <summary>
        ///   ใช้น้้าเพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร(น้ำประปาอื่น ๆ)   
        /// </summary>
        public int[] WaterActivityOther { get; set; }
       
        /// <summary>
        /// 1.ใช้เพื่ออุปโภคบริโภค
        /// </summary>
        public int DrinkOther { get; set; }

        /// <summary>
        /// 2.เพื่อรดน้้าพืชในบริเวณที่อยู่อาศัย
        /// </summary>
        public int PlantOther { get; set; }

        /// <summary>
        /// 3.ใช้เพื่อท้าเกษตร
        /// </summary>
        public int AgricultureOther { get; set; }

        /// <summary>
        /// 4.เพื่อผลิตสินค้า
        /// </summary>
        public int ProductOther { get; set; }

        /// <summary>
        /// 5.เพื่อการบริการ
        /// </summary>
        public int ServiceOther { get; set; }


       
        /// <summary>
        ///   ในรอบ 12 เดือนที่ผ่านมา มีเหตุการณ์ที่น้ำประปาไม่ไหล ติดต่อกันเกิน 3 วันหรือไม่   
        /// </summary>
        public bool WaterNotRunning { get; set; }
         /// <summary>
        ///   ถ้ามีเกิดเหตุการณ์ลักษณะนี้เป็นเวลากี่เดือน 
        /// </summary>
        public int WaterNotRunningMonth { get; set; }
    }
}