namespace VarsWebApi.Models
{
    public class QuestionForFish
    {
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นบ่อ
        /// </summary>
        public bool Depression { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นร่องสวน
        /// </summary>
        public bool GardenGroove { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นกระชัง
        /// </summary>
        public bool Stew { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงในนา
        /// </summary>
        public bool RiceField { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงในที่อื่นๆ
        /// </summary>
        public bool Other { get; set; }
       
        /// <summary>
        ///  ถ้าเลี้ยงในบ่อ หรือร่องสวน มีจ้านวนบ่อหรือ ร่องสวนรวมเท่าไร 
        /// </summary>
        public int DepressionTotal { get; set; }
         /// <summary>
        ///   ขนาดบ่อหรือร่องสวนทั้งหมดเท่ากันหรือไม่  
        /// </summary>
        public bool DepressionSize { get; set; }
        /// <summary>
        ///  บ่อหรือร่องสวน  พื้นที่ กี่ไร่ กี่งาน  กี่ตารางวา
        /// </summary>
        public Area Area { get; set; }
        /// <summary>
        /// ความลึกของบ่อกี่เมตร 
        /// </summary>
        public int Depth { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นสี่เหลี่ยม กว้าง ยาว ลึกเท่าไร 
        /// </summary>
        public SquarePool SquarePool { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นวงกลม เส้นผ่านศูนย์กลางกี่เมตร ลึก เท่าไร 
        /// </summary>
        public Circle Circle { get; set; }
        /// <summary>
        /// จ้านวนที่เลี้ยงในปัจจุบัน (รวมทุกบ่อ/ร่องสวน) 
        /// </summary>
        public int FishTotal { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}