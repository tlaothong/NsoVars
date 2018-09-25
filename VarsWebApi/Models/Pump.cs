namespace VarsWebApi.Models
{
    public class Pump
    {
        /// <summary>
        /// เป็นเครื่องสูบน้้าอัตโนมัติ ใช่หรือไม่ (ถ้าใช่ ให้ถามเครื่องถัดไป)
        /// </summary>
        public bool PumpAuto { get; set; }
        /// <summary>
        /// ใช้ระยะเวลาในการสูบน้้าต่อครั้งเท่าไร (ชั่วโมง) (ถ้าไม่ทราบ ข้ามไปถามเครื่องถัดไป)
        /// </summary>
        public int PumpUsagePerHour { get; set; }
        /// <summary>
        /// ในระยะเวลา 1 ปีสูบน้้ากี่ครั้ง
        /// </summary>
        public int PumpUsagePerYear { get; set; }
        /// <summary>
        /// มีอัตราการสูบเท่าไร (ลบ.ม./ชม.) (ถ้าทราบ ให้ข้ามไปถามเครื่องถัดไป)
        /// </summary>
        public int PumpRate { get; set; }
        /// <summary>
        /// เครื่องสูบน้้าใช้แหล่งพลังงานจากที่ใด
        /// </summary>
        public EnergySource EnergySource  { get; set; }
        /// <summary>
        /// ชนิดของเครื่องสูบ (จะโชว์ตามแหล่งพลังงานที่ตอบใน 4.5))
        /// </summary>
        public string PumpType { get; set; }
        /// <summary>
        /// ขนาดแรงม้า / วัตต์ เท่าไร
        /// </summary>
        public double HorsePower { get; set; }
        /// <summary>
        /// ขนาดท่อดูดเท่าไร (นิ้ว/หุน/มิลลิเมตร ***ให้เลือกหน่วยได้)
        /// </summary>
        public double SuctionPipeSize { get; set; }
        /// <summary>
        /// ขนาดท่อส่งเท่าไร (นิ้ว/หุน/มิลลิเมตร ***ให้เลือกหน่วยได้)
        /// </summary>
        public double PipelineSize { get; set; }
        /// <summary>
        /// ใช้น้้าจากสระนี้เพื่อท้ากิจกรรมใดบ้างคิดเป็นสัดส่วนเท่าไร
        /// </summary>
        public WaterActive WaterActive { get; set; }
        /// <summary>
        /// ปัญหาคุณภาพน้้า
        /// </summary>
        public WaterProblem WaterProblem { get; set; }

    }
}