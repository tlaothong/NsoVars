using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// สระน้้า หนองน้้า บึง 
    /// </summary>
    public class Pool
    {
        /// <summary>
        /// ในพื้นที่อยู่อาศัย สวน ไร่ นา สถานประกอบการมีสระน้้า หนองน้้า บึง หรือไม่ (ถ้าไม่มี ข้ามไปถามแหล่งน้้าถัดไป)
        /// </summary>
        public bool IsExist { get; set; }

        /// <summary>
        /// หาก “มี” มีจำนวนกี่สระ
        /// </summary>
        public int PoolCount { get; set; }

        /// <summary>
        /// ขนาดสระน้้าทั้งหมดเท่ากันหรือไม่ (ให้ถามถ้าจ้านวนสระในข้อ 5.4.2 มากกว่า 1 สระ)
        /// </summary>
        public bool PoolEqual { get; set; }

        /// <summary>
        /// ถามขนาดของสระ
        /// </summary>
        public List<FieldSize> PoolSize { get; set; }

        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมามีกี่สระที่นำน้ำมาใช้
        /// </summary>
        public int PoolCountUsage { get; set; }
        
        /// <summary>
        /// สระที่นำน้ำมาใช้ในรอบ 12 เดือน
        /// </summary>
        public List<PoolUsage> PoolUsage { get; set; }
    }
}