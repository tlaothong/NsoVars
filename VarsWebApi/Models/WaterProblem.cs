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
    }
}