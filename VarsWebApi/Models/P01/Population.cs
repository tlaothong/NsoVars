using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// สำมะโนประชากร
    /// </summary>
    public class Population
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ได้ปลูกข้าวเองหรือไม่
        /// </summary>
        public bool Skip { get; set; }

        /// <summary>
        /// จำนวนคน
        /// </summary>
        public int PersonCount { get; set; }

        /// <summary>
        /// ข้อมูลบุคคล
        /// </summary>
        public List<Person> Persons { get; set; }
        
    }
}