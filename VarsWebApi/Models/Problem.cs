namespace VarsWebApi.Models
{
    public class Problem
    {
        /// <summary>
        /// ขุ่น/ตะกอน 
        /// </summary>
        public bool TurbidWater { get; set; }

        /// <summary>
        /// เค็ม/กร่อย  
        /// </summary>
        public bool SaltWater { get; set; }
        /// <summary>
        /// น้ำกระด้าง
        /// </summary>
        public bool HardWater { get; set; }

        /// <summary>
        ///  มีกลิ่น
        /// </summary>
        public bool Odor { get; set; }

        /// <summary>
        ///  คราบมัน
        /// </summary>
        public bool FilmOfOil { get; set; }


        /// <summary>
        /// ฝ้าขาว
        /// </summary>
        public bool FogWater { get; set; }

        /// <summary>
        ///  ปริมาณน้้าประปาที่ใช้เฉลี่ยเดือนละเท่าไร
        /// </summary>
        public int Quantityusedpermonth { get; set; }

    }
}