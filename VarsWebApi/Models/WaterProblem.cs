namespace VarsWebApi.Models
{
    public class WaterProblem
    {
        /// <summary>
        /// มีปัญหาคุณภาพน้้า หรือไม่
        /// </summary>
        public bool HaveProblem { get; set; }
        /// <summary>
        /// ปัญหา
        /// </summary>
        public Problem Problem { get; set; }
        /// <summary>
        /// ปํญหาคือ
        /// </summary>
        public string ProblemDetail { get; set; }

        /// <summary>
        ///  ใช้น้้าจากบ่อน้้าบาดาลสาธารณะหรือไม่ 
        /// </summary>
        public bool PublicPool { get; set; }

        /// <summary>
        ///   ถ้าใช้น้้าบ่อน้้าบาดาลสาธารณะ ใช้จ้านวนกี่บ่อ 
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        ///   บ่อที่ 1 (ถามบ่อน้้าบาดาลสาธารณะที่ใช้อยู่ทีละบ่อ) 
        /// </summary>
        public PoolUsage Pool { get; set; }



        


    }
}