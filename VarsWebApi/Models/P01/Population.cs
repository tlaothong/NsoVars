using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// สำมะโนประชากรและเคหะ
    /// </summary>
    public class Population
    {
        /// <summary>
        /// คำคำหน้าชื่อ
        /// </summary>
        public NameTitle NameTitle { get; set; }
        public string OtherTitle { get; set; }

        /// <summary>
        /// ชื่อตัว
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// ชื่อสกุล
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// ความสัมพันธ์กับหัวหน้าครัวเรือน
        /// </summary>
        public Relationship Relationship { get; set; }

        /// <summary>
        /// เพศ
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// อายุ
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// สัญชาติ
        /// </summary>
        public Nationality Nationality { get; set; }

        /// <summary>
        /// การมีชื่อในทะเบียนบ้าน
        /// </summary>
        public Registration Registration { get; set; }
    }
}