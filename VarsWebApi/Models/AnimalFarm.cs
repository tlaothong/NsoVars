namespace VarsWebApi.Models
{
    public class AnimalFarm: ModelBase
    {
        /// <summary>
        /// การเลี้ยงสัตว์เพื่อขายหรือใช้งานเกษตร 
        /// </summary>
        public bool Animal { get; set; }
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้มีการเลี้ยงสัตว์ เพื่อขายหรือใช้งานเกษตรหรือไม่
        /// </summary>
        public int Cow { get; set; }
        /// <summary>
        /// วัว
        /// </summary>
        public int Buffalo { get; set; }
        /// <summary>
        /// ควาย
        /// </summary>
        public int Pig { get; set; }
        /// <summary>
        /// หมู
        /// </summary>
        public int Goat { get; set; }
        /// <summary>
        /// แพะ
        /// </summary>
        public int Sheep { get; set; }
        /// <summary>
        /// แกะ
        /// </summary>
        public int Chicken { get; set; }
        /// <summary>
        /// ไก่
        /// </summary>
        public int Duck { get; set; }
        /// <summary>
        /// เป็ด
        /// </summary>
        public int Goose { get; set; }
        /// <summary>
        /// ห่าน
        /// </summary>
        public int Cocoon { get; set; }
        /// <summary>
        /// ไหม(น้้าหนักรังไหมเป็น กก.) 
        /// </summary>
        public int Other { get; set; }
        /// <summary>
        /// อื่นๆ(เช่น ฟาร์มสุนัข แมว กระต่าย หนู นกกระจอกเทศ)
        /// </summary>
        public WaterSources WaterSources { get; set; }
        /// <summary>
        /// 
        /// </summary>
    }
}