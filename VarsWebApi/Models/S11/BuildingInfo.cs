using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class BuildingInfo
    {
        /// <summary>
        /// รหัสเขตแจงนับ
        /// </summary>
        public string EA { get; set; }
        /// <summary>
        /// ล้าดับที่ บ้าน/ อาคาร/สิ่ง ปลูกสร้าง
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// ชื่อถนน ล้าน้้า หรือ ละแวกบ้าน
        /// </summary>
        public string Road { get; set; }
        /// <summary>
        /// ชื่อตรอก/ซอย
        /// </summary>
        public string Alley { get; set; }
        /// <summary>
        /// ชื่อหมู่บ้าน/คอนโด/ อาคาร/ส้านักงาน/ สถาน ประกอบการ/สถาบัน ฯลฯ 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// เลขที่ บ้าน/ อาคาร
        /// </summary>
        public string HouseNo { get; set; }
        /// <summary>
        /// ละติจูด 
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// ลองจิจูด
        /// </summary>
        public double Longitude { get; set; }
        /// <summary>
        /// ประเภท บ้าน/ อาคาร/ สิ่งปลูก สร้าง 
        /// </summary>
        public BuildType BuildType { get; set; }
        /// <summary>
        /// อื่นๆ --> ระบุประเภทอาคาร
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        ///  อาคารสูง  (คอนโดฯ/แมนชั่น/แฟลต/อพาร์ทเมนท์) และ อาคารสำนักงานเอกชน 
        /// </summary>
        public Allowed Allow { get; set; }

        public List<Access> Access { get; set; }

    }
}