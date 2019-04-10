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
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
                Power = "200-300 / 0.2 - 0.4",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 15
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
                Power = "301-500 / 0.4 - 0.7",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 20
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
                Power = "501-1000 / 0.7 - 1.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 30
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
                Power = "1100 / 1.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 40
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มเจ็ท/ ปั๊มน้ำอัตโนมัติสำหรับดูดน้ำลึก",
                Power = "1500 / 2",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 50
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "200-500 / 0.2 - 0.7",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 60
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "501-1000 / 0.7 - 1.5",
                SuctionPipeSize = "1/2-1",
                PipelineSize = "1/2-1",
                PumpRate = 75
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "501-1000 / 0.7 - 1.5",
                SuctionPipeSize = "1(1/4)-2",
                PipelineSize = "1(1/2)-2",
                PumpRate = 90
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "1001-1400 / 1.5 - 2",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 110
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "1401-2000 / 2 - 2.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 130
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "2001-2500 / 2.5 - 3.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 160
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "2501-3500 / 3.5 - 4.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 200
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "3501-4500 / 4.5 - 6",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 300
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4501-5500 / 6 - 7.5",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 450
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5501-7500 / 7.5 - 10",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 750
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7501-10000 / 10 - 15",
                SuctionPipeSize = "2-3",
                PipelineSize = "2-3",
                PumpRate = 1000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "10001-15000 / 15 - 20",
                SuctionPipeSize = "2-4",
                PipelineSize = "2-4",
                PumpRate = 1250
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "15001-20000 / 20 - 25",
                SuctionPipeSize = "2-3",
                PipelineSize = "2-3",
                PumpRate = 1500
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "15001-20000 / 20 - 25",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1750
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "20001-25000 / 25 - 35",
                SuctionPipeSize = "2-4",
                PipelineSize = "2-4",
                PumpRate = 2250
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "25001-30000 / 35 - 40",
                SuctionPipeSize = "2-4",
                PipelineSize = "2-4",
                PumpRate = 3000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "30001-40000 / 40 - 55",
                SuctionPipeSize = "2-4",
                PipelineSize = "2-4",
                PumpRate = 3500
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "100-200 / 0.1 - 0.2",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 25
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "200-300 / 0.2 - 0.4",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 30
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "301-400 / 0.4 - 0.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 40
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "401-500 / 0.5 - 0.7",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 45
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "501-700 / 0.7 - 1",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 55
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "701-1000 / 1 - 1.5",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 60
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "1001-1400 / 1.5 - 2",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 75
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "1401-2000 / 2 - 2.5",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 90
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "2001-2500 / 2.5 - 3",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 120
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "2501-3500 / 3 - 4.5",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 160
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.ElecticPump,
                PumpType = "ปั๊มชัก",
                Power = "3501-4500 / 4.5 - 6",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 200
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "2000-4000 / 2 - 5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 500
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4001-5000 / 5 - 7",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 800
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5001-6000 / 7 - 8",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 900
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6001-7000 / 8 - 9",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 1200
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7001-8000 / 9 - 11",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 1500
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-9000 / 11 - 12",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 1800
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-9000 / 11 - 12",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 2000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-9000 / 11 - 12",
                SuctionPipeSize = "5",
                PipelineSize = "5",
                PumpRate = 2000
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-9000 / 11 - 12",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 2200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9001-11000 / 12 - 15",
                SuctionPipeSize = "4-8",
                PipelineSize = "4-8",
                PumpRate = 2600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "11001-13500 / 15 - 18",
                SuctionPipeSize = "4-8",
                PipelineSize = "4-8",
                PumpRate = 3000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "14000-18000 / 19 - 24",
                SuctionPipeSize = "4-8",
                PipelineSize = "4-8",
                PumpRate = 3500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.SolaPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">18000 / >24",
                SuctionPipeSize = "4-8",
                PipelineSize = "4-8",
                PumpRate = 4000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "1000-2500 / 1 - 3",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 400
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "2501-3500 / 3 - 5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "3501-4000 / 5 - 5.5",
                SuctionPipeSize = "1/2-3",
                PipelineSize = "1/2-3",
                PumpRate = 800
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4001-4500 / 5.5 - 6",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4001-4500 / 5.5 - 6",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 950
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4501-5000 / 6 - 7",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "4501-5000 / 6 - 7",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1100
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5001-6000 / 7 - 8",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 1500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6001-7000 / 8 - 9",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 1600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.PetrolPump,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">7000 / >9",
                SuctionPipeSize = "1/2-4",
                PipelineSize = "1/2-4",
                PumpRate = 1900
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "<5500 / <7",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "<5500 / <7",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "<5500 / <7",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1000
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5500-6000 / 7 - 8",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5500-6000 / 7 - 8",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 800
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "5500-6000 / 7 - 8",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6001-6500 / 8 - 9",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 800
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6001-6500 / 8 - 9",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 900
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6001-6500 / 8 - 9",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6501-7000 / 9 - 9.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 900
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6501-7000 / 9 - 9.5",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1000
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "6501-7000 / 9 - 9.5",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1300
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7001-7500 / 9.5 - 10",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 1000
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7001-7500 / 9.5 - 10",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7001-7500 / 9.5 - 10",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7501-8000 / 10 - 10.5",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 1200
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "7501-8000 / 10 - 10.5",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1300
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-8500 / 10.5 - 11",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 1300
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-8500 / 10.5 - 11",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1400
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8001-8500 / 10.5 - 11",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8501-9000 / 11 - 12",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 1500
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8501-9000 / 11 - 12",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8501-9000 / 11 - 12",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 1900
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "8501-9000 / 11 - 12",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 2200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9001-9500 / 12 - 13",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 1600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9001-9500 / 12 - 13",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 1700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9001-9500 / 12 - 13",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 2000
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9001-9500 / 12 - 13",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 2300
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9501-10500 / 13 - 14",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 2000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9501-10500 / 13 - 14",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 2100
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9501-10500 / 13 - 14",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 2400
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "9501-10500 / 13 - 14",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 2700
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "10501-11500 / 14 - 15",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 2300
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "10501-11500 / 14 - 15",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 2400
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "10501-11500 / 14 - 15",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 2700
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = "10501-11500 / 14 - 15",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 3000
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">11500 / >15",
                SuctionPipeSize = "1/2-2",
                PipelineSize = "1/2-2",
                PumpRate = 2500
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">11500 / >15",
                SuctionPipeSize = "3",
                PipelineSize = "3",
                PumpRate = 2600
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">11500 / >15",
                SuctionPipeSize = "4",
                PipelineSize = "4",
                PumpRate = 2900
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มหอยโข่ง",
                Power = ">11500 / >15",
                SuctionPipeSize = "6",
                PipelineSize = "6",
                PumpRate = 3200
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "ปั๊มเจ็ท",
                Power = "5000-12000 / 6.5 - 16",
                SuctionPipeSize = "1",
                PipelineSize = "1",
                PumpRate = 40
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "เทอร์ไบร์",
                Power = "<4000 / <5",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-4",
                PumpRate = 200
            },
            new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "เทอร์ไบร์",
                Power = "4001-5000 / 5 - 7",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-4",
                PumpRate = 300
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "เทอร์ไบร์",
                Power = "5001-6000 / 7 - 8",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-4",
                PumpRate = 450
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "เทอร์ไบร์",
                Power = "6001-7500 / 8 - 10",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-4",
                PumpRate = 600
            },
             new PumpRateModel {
                EnergyFromPump = EnergySource.TwoWheeledTractors,
                PumpType = "เทอร์ไบร์",
                Power = ">7500 / >10",
                SuctionPipeSize = "-",
                PipelineSize = "1/2-4",
                PumpRate = 800
            },
        };
    }
}