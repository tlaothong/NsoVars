namespace VarsWebApi.Models
{
    public class FrogFarming
    {
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นบ่อ
        /// </summary>
        public bool Depression { get; set; }
        /// <summary>
        ///  ลักษณะการเลี้ยงเป็นกระชัง
        /// </summary>
        public bool Stew { get; set; }
         /// <summary>
        ///  ลักษณะการเลี้ยงในที่อื่นๆ
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// จ้านวนกบที่เลี้ยงเฉลี่ยต่อเดือน เดือนละกี่ตัว
        /// </summary>
        public int FrogCount { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSourcesWithPlumbingAndRainingAsIs WaterSources { get; set; }
    }
}