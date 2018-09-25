using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models {
    /// <summary>
    /// การทำการเกษตร
    /// </summary>
    public class Agriculture : ModelBase {
        /// <summary>
        /// ข้าว
        /// </summary>
        public RicePlant RicePlant { get; set; }

        /// <summary>
        /// พืชไร่
        /// </summary>
        public AgronomyPlant AgronomyPlant { get; set; }

        /// <summary>
        /// ยางพารา 
        /// </summary>
        public RubberTree RubberTree { get; set; }

        /// <summary>
        /// พืชยืนต้น ไม้ผล สวนป่า 
        /// </summary>
        public PerennialPlant PerennialPlant { get; set; }

        /// <summary>
        /// พืชผัก สมุนไพร
        /// </summary>
        public VegetablePlant VegetablePlant { get; set; }

        /// <summary>
        /// ไม้ดอกไม้ประดับ การเพาะพันธุ์ไม้ 
        /// </summary>
        public FlowerCrop FlowerCrop { get; set; }

        /// <summary>
        /// เพาะเชื้อและปลูกเห็ด 
        /// </summary>
        public MushroomPlant MushroomPlant { get; set; }

        /// <summary>
        /// การเลี้ยงสัตว์เพื่อขายหรือใช้งานเกษตร 
        /// </summary>
        public AnimalFarm AnimalFarm { get; set; }

        /// <summary>
        /// การเพาะเลี้ยงสัตว์น้ าในพื้นที่น้ าจืด 
        /// </summary>
        public AquaticAnimals AquaticAnimals { get; set; }

    }
}