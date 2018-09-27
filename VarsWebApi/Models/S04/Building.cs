namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับปลูกสร้าง
    /// </summary>
    public class Building
    {
        /// <summary>
        /// จำนวนห้อง
        /// </summary>
        public int RoomCount { get; set; }

        /// <summary>
        /// จำนวนห้องที่มีคนอาศัย
        /// </summary>
        // TODO:
        public int Occupied { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount { get; set; }
    }
}