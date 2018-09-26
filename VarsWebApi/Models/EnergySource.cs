namespace VarsWebApi.Models
{
    /// <summary>
    /// แหล่งพลังงาน
    /// </summary>
    public class EnergySource
    {
        /// <summary>
        /// ใช้ไฟฟ้า
        /// </summary>
        public string ElecticPump { get; set; }
        /// <summary>
        /// ใช้น้้ามันดีเซล(โซล่า)
        /// </summary>
        public string SolaPump { get; set; }
        /// <summary>
        /// ใช้น้้ามันเบนซิน
        /// </summary>
        public string PetrolPump { get; set; }
        /// <summary>
        /// รถไถเดินตาม
        /// </summary>
        public string TwoWheeledTractors { get; set; }

    }
}