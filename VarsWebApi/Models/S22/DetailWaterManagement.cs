using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class DetailWaterManagement 
    {
        /// <summary>
        /// ชื่อของแหล่งน้ำ
        /// </summary>
        public string WaterSupplyName { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าน้้าประปา
        /// </summary>
        public bool UseWaterForPlumbing { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้ท้าการผลิต/อุตสาหกรรม 
        /// </summary>
        public bool UseWaterForFactory { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการเกษตร 
        /// </summary>
        public bool UseWaterForFarming { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการบริการ 
        /// </summary>
        public bool UseWaterForService { get; set; }

        /// <summary>
        /// แหล่งน้้านี้ใช้เพื่อการบริการ 
        /// </summary>
        public string UseWaterForOther { get; set; }

        /// <summary>
        /// ใช้ ไร่(Area->Rai) ตารางวา(Area-> SqWa) ความลึก(Depth)
        /// </summary>
        public FieldSize ProjectArea { get; set; }

        /// 
        /// <summary>
        /// ถ้าแหล่งน้้าเป็นสี่เหลี่ยม กว้าง(RectanglePool->Width) ยาว(RectanglePool-> Length)  ความลึก(Depth)
        /// </summary>
        public FieldSize RectanglePool { get; set; }

        /// <summary>
        ///  ใช้เส้นผ่านศูนย์กลางกี่ เมตร(Circle -> Diameter) ลึกเท่าไร(Depth)
        /// </summary>
        public FieldSize Circle { get; set; }
    }
}
