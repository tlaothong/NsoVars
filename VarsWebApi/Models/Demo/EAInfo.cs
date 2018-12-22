using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models.Demo
{
    public class EAInfo : ModelBase
    {
        /// <summary>
        /// จังหวัด
        /// </summary>
        public string IdUser { get; set; }
        /// <summary>
        /// ภาค
        /// </summary>
        public string  Zone { get; set; }
        /// <summary>
        /// จังหวัด
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// อำเภอ
        /// </summary>
        public string District { get; set; }
        /// <summary>
        /// ตำบล
        /// </summary>
        public string SubDistrict { get; set; }
        /// <summary>
        /// เขตการปกครอง
        /// </summary>
        public Region Region { get; set; }
        /// <summary>
        /// รหัสเขตแจงนับ
        /// </summary>
        public int EnumerationCode { get; set; }
        /// <summary>
        /// หมู่ที่
        /// </summary>
        public string VillageNo { get; set; }
        /// <summary>
        /// ชื่อหมู่บ้าน/ชุมชน
        /// </summary>
        public string CommunityName { get; set; }
        /// <summary>
        /// เขตชลประทาน
        /// </summary>
        public IrrigatedArea IrrigatedArea { get; set; }
    }
}
