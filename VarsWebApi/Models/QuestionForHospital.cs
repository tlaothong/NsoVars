namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับสถานพยาบาล
    /// </summary>
    public class QuestionForHospital
    {
        /// <summary>
        /// จำนวนเตียง
        /// </summary>
        public int BedCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากร
        /// </summary>
        public int PersonnelCount { get; set; }
    }
}