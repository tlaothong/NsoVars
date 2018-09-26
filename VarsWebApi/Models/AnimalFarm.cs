namespace VarsWebApi.Models
{
    public class AnimalFarm : ModelBase
    {
        /// <summary>
        /// ในรอบ 12 เดือนที่ผ่านมาครัวเรือนนี้มีการเลี้ยงสัตว์ เพื่อขายหรือใช้งานเกษตรหรือไม่
        /// </summary>
        public bool Doing { get; set; }
        // TODO: int?
        /// <summary>
        /// วัว
        /// </summary>
        public int Cow { get; set; }

        /// <summary>
        /// ควาย
        /// </summary>
        public int Buffalo { get; set; }

        /// <summary>
        /// หมู
        /// </summary>
        public int Pig { get; set; }

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
        public int Cocoon { get; set; }
        /// <summary>
        /// อื่นๆ(เช่น ฟาร์มสุนัข แมว กระต่าย หนู นกกระจอกเทศ)
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// การเลี้ยงสัตว์นี้ใช้น้้าจากแหล่งใดบ้าง
        /// </summary>
        public WaterSources WaterSources { get; set; }

    }
}