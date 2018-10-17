using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public enum Allow
    {
        /// <summary>
        /// อนุญาต 
        /// </summary>
        Allow = 1,
        /// <summary>
        ///  ไม่อนุญาต แต่ให้ข้อมูล 
        /// </summary>
        NotAllowGiveInfo = 2,
        /// <summary>
        ///  ไม่อนุญาต และไม่ให้ข้อมูล
        /// </summary>
        NotAllowNoInfo = 3,
    }
}