namespace VarsWebApi.Models
{
    /// <summary>
    /// บรรจุภัณ
    /// </summary>
    public class PackageWater
    {
        /// <summary>
        /// ประเภทของบรรจุภัณ
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// ขนาดของบรรจุภัณ
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// จำนวน
        /// </summary>
        public int Count { get; set; }
    }
}