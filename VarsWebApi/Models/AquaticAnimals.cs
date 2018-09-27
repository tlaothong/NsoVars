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
        public FishFarming Crab { get; set; }
        /// <summary>
        /// หอย
        /// </summary>
        public FishFarming ShellFish { get; set; }
        /// <summary>
        /// เต่า
        /// </summary>
        public bool Turtle { get; set; }
        /// <summary>
        /// ไรแดง
        /// </summary>
        public FishFarming Reddish { get; set; }
        // TODO:ใส่ฟอร์มเพิ่มให้ครบ

        /// <summary>
        /// กบ 
        /// </summary>
        public QuestionForFrog QuestionForForg { get; set; }
        /// <summary>
        /// จระเข้ (5.ตะพาบน้้า และ 8.เต่า ถามเหมือนกับจระเข้ทุกข้อ)
        /// </summary>
        public QuestionForCrocodile QuestionForCrocodile { get; set; }
    }
}