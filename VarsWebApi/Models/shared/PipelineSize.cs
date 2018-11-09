using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <remarks>
    /// ขนาดท่อส่ง (นิ้ว)
    /// </remarks>
    public enum PipelineSize
    {
        /// <summary>
        /// 1/2-1
        /// </summary>
        PS12_1 = 1,
        /// <summary>
        /// 1 (1/2)
        /// </summary>
        PS112 = 2,
        /// <summary>
        /// 1 (1/2)-2
        /// </summary>
        PS112_2 = 3,
        /// <summary>
        /// 1/2-1 (1/2)
        /// </summary>
        PS12_112 = 4,
        /// <summary>
        /// 1 (1/2)-3
        /// </summary>
        PS112_3 = 5,
        /// <summary>
        /// 1-3
        /// </summary>
        PS1_3 = 6,
        /// <summary>
        /// 1-4
        /// </summary>
        PS1_4 = 7,
        /// <summary>
        /// 1-5
        /// </summary>
        PS1_5 = 8,
        /// <summary>
        /// 1/2-2
        /// </summary>
        PS12_2 = 9,
        /// <summary>
        /// 1/2-3
        /// </summary>
        PS12_3 = 10,
        /// <summary>
        /// 2-3
        /// </summary>
        PS2_3 = 11,
        /// <summary>
        /// 2-4
        /// </summary>
        PS2_4 = 12,
        /// <summary>
        /// 4
        /// </summary>
        PS4 = 13,
        /// <summary>
        /// 1/2-4
        /// </summary>
        PS12_4 = 14,
        /// <summary>
        /// 5
        /// </summary>
        PS5 = 15,
        /// <summary>
        /// 6
        /// </summary>
        PS6 = 16,
        /// <summary>
        /// 4-8
        /// </summary>
        PS4_8 = 17,
        /// <summary>
        /// 3
        /// </summary>
        PS3 = 18,
        /// <summary>
        /// 1
        /// </summary>
        PS1 = 19,
    }
}