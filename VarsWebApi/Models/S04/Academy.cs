using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public bool HasPreSchool { get; set; }
        public int PreSchoolCount { get; set; }

        /// <summary>
        /// อนุบาล  
        /// </summary>
        public bool HasKindergarten { get; set; }
        public int KindergartenCount { get; set; }

        /// <summary>
        /// ประถมศึกษา  
        /// </summary>
        public bool HasPrimarySchool { get; set; }
        public int PrimarySchoolCount { get; set; }

        /// <summary>
        /// มัธยมศึกษา  
        /// </summary>
        public bool HasHighschool { get; set; }
        public int HighschoolCount { get; set; }

        /// <summary>
        /// ปวช./ปวส 
        /// </summary>
        public bool HasVocational { get; set; }
        public int VocationalCount { get; set; }

        /// <summary>
        /// อุดมศึกษา  
        /// </summary>
        public bool HasHigherEducation { get; set; }
        public int HigherEducationCount { get; set; }

        /// <summary>
        /// จำนวนบุคลากรรวมทั้งหมดทุกประเภท
        /// </summary>
        public int PersonnelCount { get; set; }


    }
}