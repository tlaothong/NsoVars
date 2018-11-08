using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    /// <summary>
    /// เครื่องสูบน้้า
    /// </summary>
    public class Pump
    {
        /// <summary>
        /// เป็นเครื่องสูบน้้าอัตโนมัติ ใช่หรือไม่ (ถ้าใช่ ให้ถามเครื่องถัดไป)
        /// </summary>
        public bool PumpAuto { get; set; }

        /// <summary>
        /// ใช้ระยะเวลาในการสูบน้้าต่อครั้งเท่าไร (ชั่วโมง) 
        /// </summary>
        public int HoursPerPump { get; set; }
       

        // TODO:Name, Missing
        /// <summary>
        /// ในระยะเวลา 1 ปีสูบน้้ากี่ครั้ง
        /// </summary>
        public int NumberOfPumpsPerYear { get; set; }

        /// <summary>
        /// ทราบอัตราการสูบหรือไม่
        /// </summary>
        public bool HasPumpRate { get; set; }

        /// <summary>
        /// มีอัตราการสูบเท่าไร (ลบ.ม./ชม.)
        /// </summary>
        public int? PumpRate { get; set; }

        /// <summary>
        /// เครื่องสูบน้้าใช้แหล่งพลังงานจากที่ใด
        /// </summary>
        /// <remarks>
        /// 1.ใช้ไฟฟ้า
        /// 2.ใช้น้้ามันดีเซล(โซล่า)
        /// 3.ใช้น้้ามันเบนซิน
        /// 4.รถไถเดินตาม
        /// </remarks>
        // TODO:
        public EnergySource EnergySource { get; set; }

        /// <summary>
        /// ชนิดของเครื่องสูบ (จะโชว์ตามแหล่งพลังงานที่ตอบใน 4.5))
        /// </summary>
        /// <remarks>
        /// 1.ใช้ไฟฟ้า
        /// 2.ใช้น้้ามันดีเซล(โซล่า)
        /// 3.ใช้น้้ามันเบนซิน
        /// 4.รถไถเดินตาม
        /// </remarks>
        // TODO: Not sure
        public PumpType PumpType { get; set; }

        /// <summary>
        /// ขนาดแรงม้า / วัตต์ เท่าไร
        /// </summary>
        public HorsePower HorsePower { get; set; }

        /// <summary>
        /// ขนาดท่อดูดเท่าไร (นิ้ว/หุน/มิลลิเมตร ***ให้เลือกหน่วยได้)
        /// </summary>
        public SuctionPipeSize SuctionPipeSize { get; set; }

        /// <summary>
        /// ขนาดท่อส่งเท่าไร (นิ้ว/หุน/มิลลิเมตร ***ให้เลือกหน่วยได้)
        /// </summary>
        public PipelineSize PipelineSize { get; set; }

    }
}