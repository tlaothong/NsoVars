namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับสถานศึกษา
    /// </summary>
    public class QuestionForAcademy:ModelBase
    {
        // TODO:Count, int?
        /// <summary>
        /// ก่อนวัยเรียน 
        /// </summary>
        public bool PreSchool  { get; set; }
        
        /// <summary>
        /// อนุบาล  
        /// </summary>
        public bool Kindergarten  { get; set; }

        /// <summary>
        /// ประถมศึกษา  
        /// </summary>
        public bool PrimarySchool  { get; set; }

        /// <summary>
        /// มัธยมศึกษา  
        /// </summary>
        public bool Highschool  { get; set; }

        /// <summary>
        /// ปวช./ปวส 
        /// </summary>
        public bool Vocational  { get; set; }

        /// <summary>
        /// อุดมศึกษา  
        /// </summary>
        public bool HigherEducation  { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount  { get; set; }


    }
}