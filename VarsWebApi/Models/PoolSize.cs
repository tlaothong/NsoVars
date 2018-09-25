namespace VarsWebApi.Models
{
    public class PoolSize
    {
        /// <summary>
        /// ทราบพื้นที่หรือไม่ กี่ไร่ กี่งาน กี่ตารางวา ความลึกของสระกี่เมตร
        /// </summary>
        public Area PoolArea { get; set; }
        /// <summary>
        /// ถ้าสระเป็นสี่เหลี่ยม กว้าง ยาว ลึกเท่าไร
        /// </summary>
        public SquarePool PoolSquare { get; set; }
        /// <summary>
        /// ถ้าสระเป็นวงกลม เส้นผ่านศูนย์กลางกี่เมตร ลึกเท่าไร
        /// </summary>
        public Circle PoolCircle { get; set; }

    }
}