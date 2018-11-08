using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ประเภทปั๊ม
    /// </summary>
    public enum PumpType
    {
        /// <summary>
        /// ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม 
        /// </summary>
        SubmergedPump = 1,
        /// <summary>
        /// ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก
        /// </summary>
        AutoForDeepPump = 2,
        /// <summary>
        /// ปั๊มหอยโข่ง 
        /// </summary>
        CentrifugalPump = 3,
        /// <summary>
        /// ปั๊มชัก
        /// </summary>
        ReciprocatingPump = 4,
        /// <summary>
        /// ปั๊มเจ็ท
        /// </summary>
        JetPump = 5,
        /// <summary>
        /// เทอร์ไบร์
        /// </summary>
        TurbinePump = 6,
        /// <summary>
        /// ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่ 
        /// </summary>
        DivoPump = 7,
        /// <summary>
        /// ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม
        /// </summary>
        AutoPump = 8,
         /// <summary>
        /// ปั๊มพญานาค
        /// </summary>
        PayanakPump = 9,
    }
}
