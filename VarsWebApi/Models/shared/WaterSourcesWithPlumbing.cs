using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    public class WaterSourcesWithPlumbing : WaterSources
    {
        /// <summary>
        /// 1. น้ำประปา
        /// </summary>
        public bool Plumbing { get; set; }
    }
}