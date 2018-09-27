namespace VarsWebApi.Models
{
    public class YearsDisasterous
    {
        
        /// <summary>
        /// ปีที่เกิดอุทกภัย 2556-2560
        /// </summary>
        public string Year { get; set; }

        /// <summary>
        /// FloodAmount - จำนวนครั้งที่เกิดอุทกภัย
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนวัน)
        /// </summary>
        public double AvgDay { get; set; }

        /// <summary>
        /// ระยะเวลาที่เกิดน้ำท่วม  (โดยเฉลี่ย : จำนวนชั่วโมง)
        /// </summary>
        public double AvgHour { get; set; }

        /// <summary>
        /// ระดับความสูงของน้ำท่วม (ซม.)
        /// </summary>
        public double Height { get; set; }
    }
}