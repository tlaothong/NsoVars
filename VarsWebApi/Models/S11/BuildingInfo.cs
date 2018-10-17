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
        /// ลำดับที่บ้าน/อาคาร/สิ่งปลูกสร้าง
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// ชื่อถนนลำน้ำหรือละแวกบ้าน
        /// </summary>
        public string Road { get; set; }
        /// <summary>
        /// ชื่อตรอก/ซอย
        /// </summary>
        public string Alley { get; set; }
        /// <summary>
        /// ชื่อหมู่บ้าน/คอนโด/อาคาร/สำนักงาน/สถานประกอบการ/สถาบัน ฯลฯ 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// เลขที่บ้าน/อาคาร
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
        /// ประเภทบ้าน/อาคาร/สิ่งปลูกสร้าง 
        /// </summary>
        public BuildType BuildType { get; set; }
        /// <summary>
        /// อื่นๆ (ระบุประเภทอาคาร)
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        ///  อาคารสูง(คอนโดฯ/แมนชั่น/แฟลต/อพาร์ทเมนท์)และอาคารสำนักงานเอกชน 
        /// </summary>
        public Allowed Allow { get; set; }

        /// <summary>
        ///  การเข้าพบบ้าน/อาคาร/สิ่งปลูกสร้าง 
        /// </summary>
        public List<Access> Access { get; set; }

    }
}