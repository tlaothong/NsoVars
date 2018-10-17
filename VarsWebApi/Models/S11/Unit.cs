using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Unit
    {
        /// <summary>
        /// ล้าดับที่ บ้าน/ อาคาร/สิ่ง ปลูกสร้าง
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// ล้าดับครัว เรือน/ สถานประ กอบ การใน อาคาร 
        /// </summary>
        public int RankHouse { get; set; }
        /// <summary>
        /// ล้าดับครัว เรือน/ สถานประ กอบ การใน อาคาร 
        /// </summary>
        public int RoomNumber { get; set; }

        public UnitAllowed MyProperty { get; set; }
        
    }
}