using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public enum AccessInfo
    {
        /// <summary>
        /// 1 มีผู้ให้ข้อมูล ให้ความรว่มมอื  
        /// </summary>
        HasPersonAndAccept = 1,
        /// <summary>
        /// 2 มีผู้ให้ข้อมลู แต่ไม่ให้ความร่วมมอื  
        /// </summary>
        HasPersonNoAccept = 2,
        /// <summary>
        /// 3 ไม่มี/ไม่พบผู้ให้ข้อมูล  
        /// </summary>
        NoPerson = 3,
        /// <summary>
        /// 4 บ้าน/อาคาร ว่าง หรือร้าง  
        /// </summary>
        EmptyHouse = 4
    }
}