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
                PipelineSize = "1 (1/2)",
                PumpRate = 40
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "200-500 / 0.2 - 0.7",
                SuctionPipeSize = "-",
                PipelineSize = "1 (1/2)-2",
                PumpRate = 50
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "501-1000 / 0.7 - 1.5",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-1 (1/2)",
                PumpRate = 50
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "501-1000 / 0.7 - 1.5",
                SuctionPipeSize = "-",
                PipelineSize = "1 (1/2)-2",
                PumpRate = 60
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "1001-1400 / 1.5 - 2",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-1 (1/2)",
                PumpRate = 70
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "1001-1400 / 1.5 - 2",
                SuctionPipeSize = "-",
                PipelineSize = "1 (1/2)-2",
                PumpRate = 80
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "1401-2000 / 2 - 2.5",
                SuctionPipeSize = "-",
                PipelineSize = "1/2- 1 (1/2)",
                PumpRate = 80
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "1401-2000 / 2 - 2.5",
                SuctionPipeSize = "-",
                PipelineSize = "1 (1/2)-3",
                PumpRate = 120
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "2001-3000 / 2.5 - 4",
                SuctionPipeSize = "-",
                PipelineSize = "1-3",
                PumpRate = 150
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "3001-5000 / 4 - 7",
                SuctionPipeSize = "-",
                PipelineSize = "1-3",
                PumpRate = 250
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "5001-7000 / 7 - 9",
                SuctionPipeSize = "-",
                PipelineSize = "1-4",
                PumpRate = 320
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "7001-10000 / 9 - 15",
                SuctionPipeSize = "-",
                PipelineSize = "1-4",
                PumpRate = 400
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "10001-14000 / 15 - 20",
                SuctionPipeSize = "-",
                PipelineSize = "1-4",
                PumpRate = 500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "15001-20000 / 20 - 25",
                SuctionPipeSize = "-",
                PipelineSize = "1-4",
                PumpRate = 600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = "50000-100000 / 65 - 135",
                SuctionPipeSize = "-",
                PipelineSize = "1-5",
                PumpRate = 1300
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มซับเมิร์ส/ปั๊มแบบจุ่ม",
                Power = ">100000 / >135",
                SuctionPipeSize = "-",
                PipelineSize = "1-5",
                PumpRate = 1600
            },

        };

    }
}