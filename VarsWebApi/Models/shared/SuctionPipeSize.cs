using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// ขนาดท่อดูด
    /// </summary>
    public enum SuctionPipeSize
    {
        /// <summary>
        /// (1/2)-1
        /// </summary>
        SP12_1 = 1,
        /// <summary>
        /// (1/2)-2
        /// </summary>
        SP12_2 = 2,
        /// <summary>
        /// (1/2)-3
        /// </summary>
        SP12_3 = 3,
        /// <summary>
        /// (1/2)-4
        /// </summary>
        SP12_4 = 4,
        /// <summary>
        /// (1/2)-6
        /// </summary>
        SP12_6 = 5,
        /// <summary>
        /// (1/2)-8
        /// </summary>
        SP12_8 = 6,
        /// <summary>
        /// (1/2)-10
        /// </summary>
        SP12_10 = 7,
        /// <summary>
        /// (1/2)-1 (1/2)
        /// </summary>
        SP12_112 = 8,
        /// <summary>
        /// 1(1/2)-2
        /// </summary>
        SP112_2 = 9,
        /// <summary>
        /// 1(1/4)-2
        /// </summary>
        SP114_2 = 10,
        /// <summary>
        /// 1
        /// </summary>
        SP1 = 11,
        /// <summary>
        /// 2
        /// </summary>
        SP2 = 12,
        /// <summary>
        /// 2-3
        /// </summary>
        SP2_3 = 13,
        /// <summary>
        /// 2-4
        /// </summary>
        SP2_4 = 14,
        /// <summary>
        /// 3
        /// </summary>
        SP3 = 15,
        /// <summary>
        /// 4
        /// </summary>
        SP4 = 16,
        /// <summary>
        /// 4 - 6
        /// </summary>
        SP4_6 = 17,
        /// <summary>
        /// 4 - 8
        /// </summary>
        SP4_8 = 18,
        /// <summary>
        /// 5
        /// </summary>
        SP5 = 19,
        /// <summary>
        /// 5 - 6
        /// </summary>
        SP5_6 = 20,
        /// <summary>
        /// 6
        /// </summary>
        SP6 = 21,
        /// <summary>
        /// 6 - 12
        /// </summary>
        SP6_12 = 22,
        /// <summary>
        /// 7 - 8
        /// </summary>
        SP7_8 = 23,
        /// <summary>
        /// 9 - 10
        /// </summary>
        SP9_10 = 24,
        /// <summary>
        /// 11 - 12
        /// </summary>
        SP11_12 = 25,
        /// <summary>
        /// "ไม่มีท่อดูด"
        /// </summary>
        Nodata = 26,
    }
}