using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{   
    /// <summary>
    /// มีหรือไม่ จำนวนเท่าไหร่
    /// </summary>
    public class HasAndCount
    {
        /// <summary>
        /// มีหรือไม่
        /// </summary>
        public bool HasItem { get; set; }
        /// <summary>
        /// จำนวนเท่าไหร่
        /// </summary>
        public int? ItemCount { get; set; }
        /// <summary>
        /// ชื่อสัตว์อื่นๆ
        /// </summary>
        public string AnimalName { get; set; }
        
    }
}