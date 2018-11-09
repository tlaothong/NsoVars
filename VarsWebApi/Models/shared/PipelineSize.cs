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
        /// (1/2)-6
        /// </summary>
        PS12_6 = 2,
        /// <summary>
        /// (1/2)-8
        /// </summary>
        PS12_8 = 3,
        /// <summary>
        /// 1 (1/2)
        /// </summary>
        PS112 = 4,
        /// <summary>
        /// 2 (1/2)
        /// </summary>
        PS212 = 5,
        /// <summary>
        /// 3 (1/2)
        /// </summary>
        PS312 = 6,
        /// <summary>
        /// 1 (1/2)-2
        /// </summary>
        PS112_2 = 7,
        /// <summary>
        /// 1/2-1 (1/2)
        /// </summary>
        PS12_112 = 8,
        /// <summary>
        /// 1 (1/2)-3
        /// </summary>
        PS112_3 = 9,
        /// <summary>
        /// 1-3
        /// </summary>
        PS1_3 = 10,
        /// <summary>
        /// 1-4
        /// </summary>
        PS1_4 = 11,
        /// <summary>
        /// 1-5
        /// </summary>
        PS1_5 = 12,
        /// <summary>
        /// 1/2-2
        /// </summary>
        PS12_2 = 13,
        /// <summary>
        /// 1/2-3
        /// </summary>
        PS12_3 = 14,
        /// <summary>
        /// 2
        /// </summary>
        PS2 = 15,
        /// <summary>
        /// 2-3
        /// </summary>
        PS2_3 = 16,
        /// <summary>
        /// 2-4
        /// </summary>
        PS2_4 = 17,
        /// <summary>
        /// 2-6
        /// </summary>
        PS2_6 = 18,
        /// <summary>
        /// 4
        /// </summary>
        PS4 = 19,
         /// <summary>
        /// 4-6
        /// </summary>
        PS4_6 = 20,
        /// <summary>
        /// 4 (1/2)
        /// </summary>
        PS412 = 21,
        /// <summary>
        /// 1/2-4
        /// </summary>
        PS12_4 = 22,
        /// <summary>
        /// 5
        /// </summary>
        PS5 = 23,
        /// <summary>
        /// 5-6
        /// </summary>
        PS5_6 = 24,
        /// <summary>
        /// 6
        /// </summary>
        PS6 = 25,
        /// <summary>
        /// 6-12
        /// </summary>
        PS6_12 = 26,
        /// <summary>
        /// 7-8
        /// </summary>
        PS7_8 = 27,
        /// <summary>
        /// 9-10
        /// </summary>
        PS9_10 = 28,
        /// <summary>
        /// 11-12
        /// </summary>
        PS11_12 = 29,
        /// <summary>
        /// 4-8
        /// </summary>
        PS4_8 = 30,
        /// <summary>
        /// 3
        /// </summary>
        PS3 = 31,
        /// <summary>
        /// 1
        /// </summary>
        PS1 = 32,
    }
}