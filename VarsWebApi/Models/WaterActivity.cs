namespace VarsWebApi.Models
{
    /// <summary>
    /// ***ปรากฏกิจกรรมเฉพาะที่ระบุไว้ก่อนหน้าว่าใช้น้้า  - ประเภทนี้
    ///*** ( สัดส่วนที่ใช้ (%) , รวมทุกกิจกรรม 100% )
    /// </summary>
    public class WaterActivity
    {
        /// <summary>
        /// 1.ใช้เพื่ออุปโภคบริโภค
        /// </summary>
        public double Drink { get; set; }

        /// <summary>
        /// 2.เพื่อรดน้้าพืชในบริเวณที่อยู่อาศัย
        /// </summary>
        public double Plant { get; set; }

        /// <summary>
        /// 3.ใช้เพื่อท้าเกษตร
        /// </summary>
        public double Agriculture { get; set; }

        /// <summary>
        /// 4.เพื่อผลิตสินค้า
        /// </summary>
        public double Product { get; set; }

        /// <summary>
        /// 5.เพื่อการบริการ
        /// </summary>
        public double Service { get; set; }
        /// <summary>
        /// 6.เพื่อท้านา
        /// </summary>
        /// <value></value>
        public double Farm { get; set; }
    }
}