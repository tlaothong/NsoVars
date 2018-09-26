namespace VarsWebApi.Models
{
    /// <summary>
    /// แหล่งพลังงาน
    /// </summary>
    // TODO:
    public class EnergySource
    {
        /// <summary>
        /// ใช้ไฟฟ้า
        /// </summary>
        public bool ElecticPump { get; set; }

        /// <summary>
        /// ใช้น้้ามันดีเซล(โซล่า)
        /// </summary>
        public bool SolaPump { get; set; }

        /// <summary>
        /// ใช้น้้ามันเบนซิน
        /// </summary>
        public bool PetrolPump { get; set; }
        
        /// <summary>
        /// รถไถเดินตาม
        /// </summary>
        public bool TwoWheeledTractors { get; set; }

    }
}