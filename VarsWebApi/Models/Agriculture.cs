using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การทำการเกษตร
    /// </summary>
    public class Agriculture : ModelBase
    {
        /// <summary>
        /// ข้าว
        /// </summary>
        public RicePlant RicePlant { get; set; }
    }
}
