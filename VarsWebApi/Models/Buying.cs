namespace VarsWebApi.Models
{
    /// <summary>
    ///  น้ำที่ซื้อมาใช้    ***แสดงข้อมูล ชนิดพืช/การผลิต/การบริการ ที่เลือกใช้น้าฝนที่กักเก็บไว้ จากตอนที่ 1-4
    /// </summary>
    // TODO: 
    public class Buying
    {
        /// <summary>
        /// บรรจุภัณฑ์
        /// </summary>
        public string NamePackage { get; set; }
        /// <summary>
        /// ขนาดของบรรจุภัณฑ์
        /// </summary>
        public double Size { get; set; }
                /// <summary>
        /// 1.ใช้เพื่ออุปโภคบริโภค
        /// </summary>
        public double CountDrink { get; set; }

        /// <summary>
        /// 2.เพื่อรดน้้าพืชในบริเวณที่อยู่อาศัย
        /// </summary>
        public double CountPlant { get; set; }

        /// <summary>
        /// 3.ใช้เพื่อท้าเกษตร
        /// </summary>
        public double CountAgriculture { get; set; }

        /// <summary>
        /// 4.เพื่อผลิตสินค้า
        /// </summary>
        public double CountProduct { get; set; }

        /// <summary>
        /// 5.เพื่อการบริการ
        /// </summary>
        public double CountService { get; set; }
        /// <summary>
        /// 6.เพื่อท้านา
        /// </summary>
        public double CountFarm { get; set; }
    }
}