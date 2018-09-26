using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    /// <summary>
    /// การค้าและบริการ
    /// </summary>
    public class Commercial: ModelBase
    {
        /// <summary>
        /// ชื่อสถานประกอบการ / หน่วยงาน
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// สถาณประกอบการให้บริการในลักษณะใด
        /// </summary>
        // TODO:
        public string ServiceType { get; set; }

        /// <summary>
        /// สถานศึกษา/โรงเรียน/สถาบันการศึกษา
        /// </summary>
        public QuestionForAcademy QuestionForAcademy { get; set; }

        /// <summary>
        ///  โรงแรม/รีสอร์ท/เกสต์เฮาส์
        /// </summary>
        public QuestionForHotelsAndResorts HotelsAndResorts { get; set; }

        /// <summary>
        /// สถานพยาบาล/โรงพยาบาล/สถานสงเคราะห์
        /// </summary>
        public QuestionForHospital Hospital { get; set; }

        /// <summary>
        /// คอนโด/อพาร์ทเม้นต์/หอพัก/แมนชั่น/แฟลต
        /// </summary>
        public QuestionForBuilding Building { get; set; }

        /// <summary>
        /// ศาสนสถาน/วัด/ส้านักสงฆ์/ส้านักปฏิบัติธรรม
        /// </summary>
        public QuestionForReligious  Religious { get; set; }

        /// <summary>
        /// สถานประกอบการบริการประเภทอื่น ๆ
        /// </summary>
        public QuestionForOtherBuilding OtherBuilding { get; set; }


        /// <summary>
        /// ใช้แหล่งน้ำ
        /// </summary>
        public WaterSources WaterSources { get; set; }


    }
}
