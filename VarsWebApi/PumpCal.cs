using System.Collections.Generic;
using System.Linq;
using VarsWebApi.Models;

namespace VarsWebApi
{
    public class PumpCal
    {
        public static List<PumpRateModel> ListPumpGroundWater = new List<PumpRateModel>{
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "200-500 / 0.2 - 0.7",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-1",
                PumpRate = 30
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "200-500 / 0.2 - 0.7",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-1",
                PumpRate = 30
            },

        };

    }
}