namespace VarsWebApi.Models
{
    /// <summary>
    /// ปัญหาคุณภาพน้้า
    /// </summary>
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
    }
}