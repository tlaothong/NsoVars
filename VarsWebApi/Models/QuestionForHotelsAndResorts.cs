namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับสถานบริการห้องพัก
    /// </summary>
    public class QuestionForHotelsAndResorts
    {
        /// <summary>
        /// จำนวนห้องพัก
        /// </summary>
        public int RoomCount { get; set; }

         /// <summary>
        /// จำนวนบุคลากร
        /// </summary>
        public int PersonnelCount { get; set; }
    }
}