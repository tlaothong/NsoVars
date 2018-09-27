using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace VarsWebApi.Models
{
    /// <summary>
    /// การบริหารจัดการน้ำ เพื่อการเกษตร
    /// </summary>
    public class ManagementForFarming
    {
        /// <summary>
        ///  ในหมู่บ้าน/ชุมชนแห่งนี้มีโครงการจัดการน้้าเพื่อการเกษตรชุมชน โดยใช้พื้นที่สาธารณะหรือไม่ (โครงการที่ใช้งบประมาณจากส่วนท้องถิ่น)  
        /// </summary>
        public bool HaveManagementForFarming { get; set; }

        /// <summary>
        /// จำนวนโครงการการจัดการน้้าเพื่อการเกษตรชุมชน
        /// </summary>
        public List<DetailManagementForFarming> DetailManagementForFarming { get; set; }
    }
}