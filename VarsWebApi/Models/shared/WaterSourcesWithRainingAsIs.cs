using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
        public class WaterSourcesWithRainingAsIs: WaterSources
    {
      
        /// <summary>
        /// 7. น้ำฝนตามธรรมชาติ
        /// </summary>
        public bool RainingAsIs { get; set; }    
        
    }
}