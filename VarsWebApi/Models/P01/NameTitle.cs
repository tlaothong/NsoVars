using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// คำนำหน้าชื่อ
    /// </summary>
    public enum NameTitle
    {
        /// <summary>
        /// นาย 
        /// </summary>
        Mr = 1,

        /// <summary>
        /// นาง
        /// </summary>
        Ms = 2,

        /// <summary>
        /// นางสาว
        /// </summary>
        Miss = 3,

        /// <summary>
        /// เด็กชาย
        /// </summary>
        Boy = 4,

        /// <summary>
        /// เด็กหญิง
        /// </summary>
        Girl = 5,

        /// <summary>
        /// อื่นๆ
        /// </summary>
        Other = 6
    }
}