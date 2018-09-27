namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับสถานพยาบาล
    /// </summary>
    public class Hospital
    {
        /// <summary>
        /// จำนวนเตียง
        /// </summary>
        public int BedCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount { get; set; }
    }
}