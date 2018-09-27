namespace VarsWebApi.Models
{
    /// <summary>
    /// คำถามสำหรับสถานศึกษา
    /// </summary>
    public class Academy 
    {
        // TODO:Count, int?
        /// <summary>
        /// ก่อนวัยเรียน 
        /// </summary>
        public bool PreSchool { get; set; }
        public int PreSchoolCount { get; set; }

        /// <summary>
        /// อนุบาล  
        /// </summary>
        public bool Kindergarten { get; set; }
        public int KindergartenCount { get; set; }

        /// <summary>
        /// ประถมศึกษา  
        /// </summary>
        public bool PrimarySchool { get; set; }
        public int PrimarySchoolCount { get; set; }

        /// <summary>
        /// มัธยมศึกษา  
        /// </summary>
        public bool Highschool { get; set; }
        public int HighschoolCount { get; set; }

        /// <summary>
        /// ปวช./ปวส 
        /// </summary>
        public bool Vocational { get; set; }
        public int VocationalCount { get; set; }

        /// <summary>
        /// อุดมศึกษา  
        /// </summary>
        public bool HigherEducation { get; set; }
        public int HigherEducationCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount { get; set; }


    }
}