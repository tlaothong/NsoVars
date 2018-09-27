namespace VarsWebApi.Models
{
    /// <summary>
    /// 2.8 การเลี้ยงสัตว์เพื่อขายหรือใช้งานเกษตร 
    /// </summary>
    public class Farming : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้มีการเลี้ยงสัตว์ เพื่อขายหรือใช้งานเกษตรหรือไม่
        /// </summary>
        public bool Doing { get; set; }
        // TODO: bool HasXXX, int XXXCount
        /// <summary>
        /// วัว
        /// </summary>
        public bool HasCow { get; set; }
        public int CowCount { get; set; }

        /// <summary>
        /// ควาย
        /// </summary>
        public bool HasBuffalo { get; set; }
        public int BuffaloCount { get; set; }

        /// <summary>
        /// หมู
        /// </summary>
        public bool HasPig { get; set; }
        public int PigCount { get; set; }

        /// <summary>
        /// แพะ
        /// </summary>
        public int Goat { get; set; }

        /// <summary>
        /// แกะ
        /// </summary>
        public int Sheep { get; set; }

        /// <summary>
        /// ไก่
        /// </summary>
        public int Chicken { get; set; }
        
        /// <summary>
        /// เป็ด
        /// </summary>
        public int Duck { get; set; }
        /// <summary>
        /// ห่าน
        /// </summary>
        public int Goose { get; set; }
        /// <summary>
        /// ไหม(น้้าหนักรังไหมเป็น กก.)
        /// </summary>
        public bool HasSilkWool { get; set; }
        public int SilkWoolCount { get; set; }
        /// <summary>
        /// อื่นๆ(เช่น ฟาร์มสุนัข แมว กระต่าย หนู นกกระจอกเทศ)
        /// </summary>
        public string OtherName { get; set; }
        public int OtherCount { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSourcesWithPlumbingAndRainingAsIs WaterSources { get; set; }

    }
}