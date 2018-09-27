namespace VarsWebApi.Models
{
    /// <summary>
    /// การเลี้ยงสัตว์น้ำ
    /// </summary>
    public class AquaticAnimals : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้ท้าการเพาะเลี้ยง เพาะฟัก อนุบาลสัตว์น้้าในพื้นที่น้้าจืดหรือไม่ 
        /// </summary>
        public bool Doing { get; set; }
        /// <summary>
        /// ปลา
        /// </summary>
        public FishFarming Fish { get; set; }        
        /// <summary>
        /// กุ้ง
        /// </summary>
        public FishFarming Shrimp { get; set; }
        /// <summary>
        /// กบ
        /// </summary>
        public FrogFarming Frog { get; set; }
        /// <summary>
        /// จระเข้
        /// </summary>
        public CrocodileFarming Crocodile { get; set; }
        /// <summary>
        /// ตะพาบน้ำ
        /// </summary>
        public CrocodileFarming SnappingTurtle { get; set; }
        /// <summary>
        /// ปู
        /// </summary>
        public FishFarming Crab { get; set; }
        /// <summary>
        /// หอย
        /// </summary>
        public FishFarming ShellFish { get; set; }
        /// <summary>
        /// เต่า
        /// </summary>
        public CrocodileFarming Turtle { get; set; }
        /// <summary>
        /// ไรแดง
        /// </summary>
        public FishFarming Reddish { get; set; }
        // TODO:ใส่ฟอร์มเพิ่มให้ครบ - (เสร็จแล้ว)
    }
}