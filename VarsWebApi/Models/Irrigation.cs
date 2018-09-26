namespace VarsWebApi.Models
{
    public class Irrigation
    {
        /// <summary>
        /// พืชหลัก
        /// </summary>
        public string MainPlantingList { get; set; }
        /// <summary>
        /// น้้ำจากชลประทาน 
        /// </summary>
        public PoolUsage PoolUsageIrrigation { get; set; }

        
    }
}