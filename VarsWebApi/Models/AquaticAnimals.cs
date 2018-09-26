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
        public bool Fish { get; set; }
        /// <summary>
        /// กุ้ง
        /// </summary>
        public bool Shrimp { get; set; }
        /// <summary>
        /// กบ
        /// </summary>
        public bool Frog { get; set; }
        /// <summary>
        /// จระเข้
        /// </summary>
        public bool Crocodile { get; set; }
        /// <summary>
        /// ตะพาบน้ำ
        /// </summary>
        public bool SnappingTurtle { get; set; }
        /// <summary>
        /// ปู
        /// </summary>
        public bool Crab { get; set; }
        /// <summary>
        /// หอย
        /// </summary>
        public bool ShellFish { get; set; }
        /// <summary>
        /// เต่า
        /// </summary>
        public bool Turtle { get; set; }
        /// <summary>
        /// ไรแดง
        /// </summary>
        public bool Reddish { get; set; }
        // TODO:ใส่ฟอร์มเพิ่มให้ครบ
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        
        public QuestionForFish QuestionForFish { get; set; }

        public QuestionForFog QuestionForFog { get; set; }

        public QuestionForCrocodile QuestionForCrocodile { get; set; }
    }
}