using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class FarmingWaterSources : WaterSources
    {
        /// <summary>
        /// 1. น้ำประปา
        /// </summary>
        public bool Plumbing { get; set; }
        /// <summary>
        /// 8. น้ำฝนตามธรรมชาติ
        /// </summary>
        public bool RainingAsIs { get; set; }
    }
}
