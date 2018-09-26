namespace VarsWebApi.Models
{
    public class QuestionForCrocodile
    {
         /// <summary>
        ///  ลักษณะการเลี้ยงเป็นบ่อ
        /// </summary>
        public  bool Depression { get; set; }
         /// <summary>
        ///  ลักษณะการเลี้ยงในที่อื่นๆ
        /// </summary>
        public  bool Other { get; set; }
         /// <summary>
        ///  ถ้าเลี้ยงในบ่อ มีจ้านวนบ่อเท่าไร 
        /// </summary>
        public int DepressionTotal { get; set; }
         /// <summary>
        ///  บ่อ พื้นที่ กี่ไร่ กี่งาน  กี่ตารางวา
        /// </summary>
        public Area Area { get; set; }
        /// <summary>
        /// ความลึกของบ่อกี่เมตร 
        /// </summary>
        public int Depth { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นสี่เหลี่ยม กว้าง ยาว ลึกเท่าไร 
        /// </summary>
        public RectanglePool RectanglePool { get; set; }
        /// <summary>
        ///  ถ้าบ่อเป็นวงกลม เส้นผ่านศูนย์กลางกี่เมตร ลึก เท่าไร 
        /// </summary>
        public Circle Circle { get; set; }
        /// <summary>
        /// จ้านวนที่เลี้ยงเฉลี่ยต่อเดือน เดือนละกี่ตัว
        /// </summary>
        public int AmountCrocodilePerMonth { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }
    }
}