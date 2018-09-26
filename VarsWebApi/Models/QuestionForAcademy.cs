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
        /// ก่อนวัยเรียนกี่คน
        /// </summary>
        public int PreSchoolCount  { get; set; }
        
        /// <summary>
        /// อนุบาล  
        /// </summary>
        public bool Kindergarten  { get; set; }

        /// <summary>
        /// อนุบาลกี่คน
        /// </summary>
         public int KindergartenCount  { get; set; }

        /// <summary>
        /// ประถมศึกษา  
        /// </summary>
        public bool PrimarySchool  { get; set; }

        /// <summary>
        /// ประถมศึกษากี่คน
        /// </summary>
         public int PrimarySchoolCount  { get; set; }

        /// <summary>
        /// มัธยมศึกษา  
        /// </summary>
        public bool Highschool  { get; set; }

        /// <summary>
        /// มัธยมศึกษากี่คน
        /// </summary>
         public int HighschoolCount  { get; set; }

        /// <summary>
        /// ปวช./ปวส 
        /// </summary>
        public bool Vocational  { get; set; }

        /// <summary>
        /// ปวช./ปวส กี่คน
        /// </summary>
         public int VocationalCount  { get; set; }

        /// <summary>
        /// อุดมศึกษา  
        /// </summary>
        public bool HigherEducation  { get; set; }

        /// <summary>
        /// อุดมศึกษากี่คน
        /// </summary>
         public int HigherEducationCount  { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount  { get; set; }


    }
}