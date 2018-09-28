using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    /// <summary>
    /// ปัญหาคุณภาพน้ำ
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// เค็ม/กร่อย  
        /// </summary>
        public bool SaltWater { get; set; }
        /// <summary>
        ///  มีกลิ่น
        /// </summary>
        public bool Odor { get; set; }

        /// <summary>
        ///  คราบมัน
        /// </summary>
        public bool FilmOfOil { get; set; }

        /// <summary>
        /// ฝ้าขาว
        /// </summary>
        public bool FogWater { get; set; }

    }
}