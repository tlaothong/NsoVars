namespace VarsWebApi.Models
{
    public class BuyingInfo
    {
        /// <summary>
        /// ขนาดของภาชนะ 
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// เพื่ออุปโภค บริโภค 
        /// </summary>
        public int Drink { get; set; }
        /// <summary>
        /// เพื่อท้า เกษตร 
        /// </summary>
        public int Plant { get; set; }
        /// <summary>
        /// เพื่อผลิต สินค้า
        /// </summary>
        public int Product { get; set; }
        /// <summary>
        /// เพื่อการ บริการ
        /// </summary>
        public int Service { get; set; }
    }
}