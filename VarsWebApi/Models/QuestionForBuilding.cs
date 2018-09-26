namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับปลูกสร้าง
    /// </summary>
    public class QuestionForBuilding
    {
        /// <summary>
        /// จำนวนห้อง
        /// </summary>
        public int RoomCount { get; set; }

        /// <summary>
        /// จำนวนห้องที่มีคนอาศัย
        /// </summary>
        public int StayCountRoom { get; set; }

        /// <summary>
        /// จำนวนบุคลากร
        /// </summary>
        public int PersonnelCount { get; set; }
    }
}