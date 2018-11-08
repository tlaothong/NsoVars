using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public enum HorsePower
    {
        /// <summary>
        /// 0.05 - 0.1
        /// </summary>
        /// <remarks>
        /// น้ำผิวดิน - ไฟฟ้า - ปั๊มไดโว่/ปั๊มจุ่ม/ปั๊มแช่ 
        /// </remarks>
        Num1 = 1,
        /// <summary>
        /// 0.1 - 0.2
        /// </summary>
        Num2 = 2,
        /// <summary>
        /// 0.2 - 0.4
        /// </summary>
        Num3 = 3,
        /// <summary>
        /// 0.4 - 0.6
        /// </summary>
        Num4 = 4,
        /// <summary>
        /// 0.6 - 0.7
        /// </summary>
        Num5 = 5,
        /// <summary>
        /// 0.7 - 1
        /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 1 - 1.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 1.5 - 1.7
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 1.7 - 2
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 2 - 2.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 2.5 - 4
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 4 -7
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 7 - 9.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >9.5
        // /// </summary>
        // Num1 = 1,

        // ////////////////////////
        // /// <summary>
        // /// 0.05 - 0.1
        // /// </summary>
        // /// <remarks>
        // /// ไฟฟ้า - ปั๊มน้ำอัตโนมัติ ถังกลม/ ถังเหลี่ยม 
        // /// </remarks>
        // Num1 = 1,
        // /// <summary>
        // /// 0.1 - 0.3
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 0.3 - 0.4
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 0.4 - 0.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 0.5 - 0.7
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 0.7 - 0.9
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 0.9 - 1
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >1
        // /// </summary>
        // Num1 = 1,

        // ////////////////////////
        // /// <summary>
        // /// 0.2 - 0.5
        // /// </summary>
        // /// <remarks>
        // /// ไฟฟ้า - ปั๊มหอยโข่ง
        // /// </remarks>
        // Num1 = 1,
        // /// <summary>
        // /// 0.5 - 0.1
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 1 - 1.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 1.5 - 2
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 2 - 3
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 3 - 3.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 5 - 6
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 6 - 8
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 8 - 11
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 11 - 15
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 15 - 20
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 20 - 23
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 23 - 25
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 25 - 35
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 40 - 47
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 47 - 55
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >55
        // /// </summary>
        // Num1 = 1,

        // ////////////////////////
        // /// <summary>
        // /// 1 - 5
        // /// </summary>
        // /// <remarks>
        // /// น้ำมันดีเซล - ปั๊มหอยโข่ง/ปั๊มพญานาค
        // /// </remarks>
        // Num1 = 1,
        // /// <summary>
        // /// 5 - 7
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 7 - 8
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 8 - 9.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 9.5 - 11
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 11 - 12
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 12 - 14
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 14 - 16
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 16 - 20
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 20 - 25
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 25 - 40
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 40 - 55
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 55 - 70
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 70 - 80
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 80 - 105
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 105 - 150
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >150
        // /// </summary>
        // Num1 = 1,

        // ////////////////////////
        // /// <summary>
        // /// 2.5 - 5.5
        // /// </summary>
        // /// <remarks>
        // /// น้ำมันเบนซิน - ปั๊มหอยโข่ง/ปั๊มพญานาค
        // /// </remarks>
        // Num1 = 1,
        // /// <summary>
        // /// 5.5 - 6
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 6 - 6.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 6.5 - 8
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 8 - 9.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 9.5 - 10.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 10.5 - 13
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >13
        // /// </summary>
        // Num1 = 1,
        
           
        // ////////////////////////
        // /// <summary>
        // /// < 7
        // /// </summary>
        // /// <remarks>
        // /// รถไถเดินตาม - ปั๊มหอยโข่ง/ปั๊มพญานาค
        // /// </remarks>
        // Num1 = 1,
        // /// <summary>
        // /// 7 - 8
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 8 - 9
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 9 - 9.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 9.5 - 11
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 11 - 11.5
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 11.5 - 12
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 12 - 13
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 13 - 15
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// 15 - 16
        // /// </summary>
        // Num1 = 1,
        // /// <summary>
        // /// >16
        // /// </summary>
        // Num1 = 1,
       
    }
}