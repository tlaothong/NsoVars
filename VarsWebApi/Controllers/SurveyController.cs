using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VarsWebApi.Models;

namespace VarsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        public ActionResult<HouseHoldSample> Get()
        {
            return new HouseHoldSample()
            {
                _id = "1234",
                Residence = new Residential()
                {
                    MemberCount = 5,
                    WorkingAge = 2,
                    WaterSources = new WaterSources()
                    {
                        Plumbing = true,
                        UnderGround = false,
                        Pool = false,
                        River = false,
                        Irrigation = false,
                        Rain = true,
                        Buying = true,
                        Other = "no"
                    },
                    GardeningUse = true
                },
                Agriculture = new Agriculture()
                {
                    RicePlant = new PlantingInfo<RicePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<RicePlantingField>(){
                            new RicePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 5,
                                    Ngan = 3,
                                    SqWa = 1
                                },
                                PlantingCount = 1,
                                PlantingArea = PlantingArea.AllArea,
                                AreaUsed = new List<Area>(){
                                    new Area(){
                                        Rai = 5,
                                        Ngan = 3,
                                        SqWa = 1
                                    }
                                },
                                Harvests = new List<RicePlantingHarvest>
                                {
                                    new RicePlantingHarvest {
                                        PlantingFromMonth = 6,
                                        PlantingThruMonth = 11,
                                        WaterFillingCount = 1,
                                        WaterHighCm = 2,
                                    }
                                },
                                IrrigationField = false,
                                WaterSources = new WaterSources(){
                                    UnderGround = false,
                                    Pool = false,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    Buying = true,
                                    RainingAsIs = true,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    AgronomyPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<GrowingFieldWithNames>(){
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 5,
                                    Ngan = 2,
                                    SqWa = 78,
                                },
                                IrrigationField = false,
                                Plantings = new List<PlantItem> {
                                    new PlantItem { Code = "232", Name = "ยาสูบ" },
                                    new PlantItem { Code= "323", Name="แตงโม" }
                                },
                                OtherPlantings = new List<PlantItem> {
                                    new PlantItem { Code = "3001", Name="ยาสูบชนิดใหม่" },
                                },
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    RubberTree = new PlantingInfo<GrowingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<GrowingField>(){
                            new GrowingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 15,
                                    Ngan = 3,
                                    SqWa = 300
                                },
                                IrrigationField = true,
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    PerennialPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<GrowingFieldWithNames>(){
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 7,
                                    Ngan = 2,
                                    SqWa = 255
                                },
                                IrrigationField = false,
                                Names = new [] {"กล้วย", "องุ่น", "มะพร้าว", "แอ๊ปเปิ้ล", "เงาะ "},
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    HerbsPlant = new PlantingInfo<MixablePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<MixablePlantingField>(){
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 1,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Names = new [] {"กะหล่้าปลี","คะน้า","ตะไคร้ ","พริกไทย","ผักชี"},
                                ThisPlantOnly = false,
                                MixedWithPrimaryPlant = "RubberTree",
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    FlowerCrop = new PlantingInfo<MixablePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<MixablePlantingField>(){
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 0,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Names = new [] {"เข็ม","กล้วยไม้","เฟื่องฟ้า","มะลิ","หญ้าปสูนาม"},
                                ThisPlantOnly = false,
                                MixedWithPrimaryPlant = "RubberTree",
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    MushroomPlant = new PlantingInfo<GrowingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<GrowingField>(){
                            new GrowingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    Distric = "เมือง",
                                    SubDistric = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 0,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = true,
                                WaterSources = new WaterSources(){
                                    Plumbing = false,
                                    UnderGround = false,
                                    Pool = true,
                                    River = false,
                                    Irrigation = false,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    AnimalFarm = new Farming()
                    {                        
                        Doing = true,
                        Cow = new HasAndCount(){
                            HasItem = true,
                            ItemCount = 2
                        },
                        Pig = new HasAndCount(){
                            HasItem = true,
                            ItemCount = 5
                        },
                        Chicken = new HasAndCount(){
                            HasItem = true,
                            ItemCount = 40
                        },
                        Duck = new HasAndCount(){
                            HasItem = true,
                            ItemCount = 12
                        },
                        Other = new HasAndCount(){
                            HasItem = true,
                            ItemCount = 2
                        },                        
                        OtherName = "Dog",
                        WaterSources = new WaterSources()
                        {
                            Plumbing = true,
                            UnderGround = true,
                            Pool = true,
                            River = false,
                            Irrigation = true,
                            Rain = true,
                            RainingAsIs = true,
                            Buying = false,
                            Other = "no"
                        }
                    },
                    AquaticAnimals = new AquaticAnimals()
                    {
                        Doing = true,
                        Fish = new FishFarming()
                        {
                            Doing = true,
                            Stew = true,
                            FieldCount = 5,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Area,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Depth = 2
                                }
                            },
                            AnimalsCount = 200,
                            WaterSources = new WaterSources()
                            {
                                Plumbing = true,
                                UnderGround = true,
                                Pool = true,
                                River = false,
                                Irrigation = true,
                                Rain = true,
                                RainingAsIs = true,
                                Buying = false,
                                Other = "no"
                            }
                        },
                        Frog = new FrogFarming()
                        {
                            Doing = true,
                            Depression = true,
                            AnimalsCount = 500,
                            WaterSources = new WaterSources()
                            {
                                Plumbing = true,
                                UnderGround = true,
                                Pool = true,
                                River = false,
                                Irrigation = true,
                                Rain = true,
                                RainingAsIs = true,
                                Buying = false,
                                Other = "no"
                            }
                        },
                        Crocodile = new CrocodileFarming()
                        {
                            Doing = true,
                            Depression = true,
                            FieldCount = 2,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 8,
                                    },
                                    Depth = 4
                                }
                            },
                            AnimalsCount = 51,
                            WaterSources = new WaterSources()
                            {
                                Plumbing = true,
                                UnderGround = true,
                                Pool = true,
                                River = false,
                                Irrigation = true,
                                Rain = true,
                                RainingAsIs = true,
                                Buying = false,
                                Other = "no"
                            }
                        }

                    }
                },
                Factory = new Factorial()
                {
                    Name = "บ้านซอ",
                    Category = "ยาสูบ",
                    WorkersCount = 2,
                    HeavyMachine = false,
                    WaterSources = new WaterSources()
                    {
                        Plumbing = true,
                        UnderGround = true,
                        Pool = true,
                        River = false,
                        Irrigation = true,
                        Rain = true,
                        Buying = false,
                        Other = "no"
                    },
                    HasWasteWaterFromProduction = true,
                    HasWasteWaterTreatment = true,
                    WasteWaterReuse = false
                },
                Commerce = new Commercial()
                {
                    Name = "บ้านซอ",
                    ServiceType = "โรงงาน",
                    OtherBuilding = new OtherBuilding()
                    {
                        PersonnelCount = 1,
                    },
                    WaterSources = new WaterSources()
                    {
                        Plumbing = true,
                        UnderGround = true,
                        Pool = true,
                        River = false,
                        Irrigation = true,
                        Rain = true,
                        Buying = false,
                        Other = "no"
                    }
                },
                WaterUsage = new WaterUsage()
                {
                    Plumbing = new Plumbing()
                    {
                        MWA = new PlumbingInfo()
                        {
                            Doing = false
                        },
                        PWA = new PlumbingInfo()
                        {
                            Doing = false
                        },
                        Other = new PlumbingInfo()
                        {
                            Doing = true,
                            WaterQuality = true,
                            Problem = new Problem()
                            {
                                TurbidWater = true,
                                HardWater = true,
                            },
                            PlumbingUsage = new PlumbingUsage()
                            {
                                WaterQuantity = WaterQuantity.WaterBill,
                                WaterBill = 569
                            }
                        },
                        WaterActivityMWAPWA = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 0,
                            Agriculture = 0,
                            Product = 0,
                            Service = 0
                        },
                        WaterActivityOther = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 5,
                            Agriculture = 0,
                            Product = 80,
                            Service = 15
                        },
                        WaterNotRunning = false
                    },
                    GroundWater = new GroundWater()
                    {
                        PrivateGroundWater = true,
                        GroundWaterCount = 1,
                        UseGroundWaterCount = 1,
                        AvgUsageWater = new List<AvgUsageWaterBill>(){
                            new AvgUsageWaterBill(){
                                UsageType = new GroundWaterUsage(){
                                    GroundWaterQuantity = GroundWaterQuantity.Unknown
                                },
                                HasPump = true,
                                PumpCount = 1,
                                Pumps = new List<Pump>(){
                                    new Pump(){
                                        PumpAuto = false,
                                        NumberOfPumpsPerYear = 125,
                                        PumpRate = new PumpRate(){
                                            KnowPumpRate = true,
                                            PumpRateUsage = 7
                                        },
                                        EnergySource = EnergySource.ElecticPump,
                                        PumpType = EnergySource.ElecticPump,
                                        HorsePower = 72.329,
                                        SuctionPipeSize = 5,
                                        PipelineSize = 3
                                    }
                                },
                                UsageActivities = new WaterActivity(){
                                    Drink = 0,
                                    Plant = 5,
                                    Farm = 0,
                                    Agriculture = 0,
                                    Product = 80,
                                    Service = 15
                                },
                                HasQaulityProblem = true,
                                QualityProblems = new Problem(){
                                    TurbidWater = true,
                                    SaltWater = true,
                                    HardWater = true
                                }
                            }
                        },
                        PublicGroundWater = false,
                    },
                    River = new River()
                    {
                        HasPump = true,
                        PumpCount = 1,
                        Pumps = new List<Pump>(){
                            new Pump(){
                                PumpAuto = false,
                                HoursPerPump = 2,
                                NumberOfPumpsPerYear = 224,
                                PumpRate = new PumpRate(){
                                    KnowPumpRate = true,
                                    PumpRateUsage = 6
                                },
                                EnergySource = EnergySource.ElecticPump,
                                PumpType = EnergySource.ElecticPump,
                                HorsePower = 87,
                                SuctionPipeSize = 16,
                                PipelineSize = 24
                            }
                        },
                        UsageActivities = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 15,
                            Farm = 20,
                            Agriculture = 0,
                            Product = 50,
                            Service = 15
                        },
                        QualityProblem = new WaterProblem()
                        {
                            HasProblem = true,
                            Problem = new Problem()
                            {
                                TurbidWater = true
                            }
                        }
                    },
                    Pool = new Pool()
                    {
                        IsExist = true,
                        PoolCount = 1,
                        PoolEqual = true,
                        PoolSize = new List<FieldSize>(){
                            new FieldSize(){
                                Shape = FieldShape.Circle,
                                Depth = 3,
                                Diameter = 25
                            }
                        },
                        PoolCountUsage = 1,
                        PoolUsage = new List<PoolUsage>(){
                            new PoolUsage(){
                                CubicMeterPerMonth = 30,
                                HasPump = true,
                                PumpCount = 1,
                                Pump = new List<Pump>(){
                                    new Pump(){
                                        PumpAuto = false,
                                        HoursPerPump = 3,
                                        NumberOfPumpsPerYear = 2,
                                        PumpRate = new PumpRate(){
                                            KnowPumpRate = true,
                                            PumpRateUsage = 79
                                        },
                                        EnergySource = EnergySource.ElecticPump,
                                        PumpType = EnergySource.ElecticPump,
                                        HorsePower = 1250,
                                        SuctionPipeSize = 4,
                                        PipelineSize = 3
                                    }
                                },
                                WaterActivity = new WaterActivity(){
                                    Drink = 0,
                                    Plant = 5,
                                    Farm = 40,
                                    Agriculture = 0,
                                    Product = 40,
                                    Service = 15
                                },
                                WaterProblem = new WaterProblem(){
                                    HasProblem = true,
                                    Problem = new Problem(){
                                        TurbidWater =true
                                    }
                                }
                            }
                        }
                    },
                    Irrigation = new PoolUsage()
                    {
                        CubicMeterPerMonth = 75,
                        HasPump = false,
                        WaterActivity = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 5,
                            Farm = 0,
                            Agriculture = 0,
                            Product = 80,
                            Service = 15
                        },
                        WaterProblem = new WaterProblem()
                        {
                            HasProblem = false
                        }
                    },
                    Rain = new Rain()
                    {
                        PackageWater = new PackageWater()
                        {
                            Category = "โอ่ง",
                            Size = 1000,
                            Count = 5
                        },
                        WaterActive = new WaterActivity()
                        {
                            Drink = 60,
                            Plant = 5,
                            Agriculture = 0,
                            Product = 20,
                            Service = 15
                        }
                    },
                    Buying = new Buying()
                    {
                        Package = new List<Package>(){
                            new Package(){
                                Name = "ขวด",
                                Size = 1,
                                Drink = 100
                            }
                        }
                    }
                },
                Disaster = new Disasterous()
                {
                    Flooded = false
                },
                Closing = new ClosingInfo()
                {
                    Informer = "SorrY",
                    FactorialCategoryCode = "3245",
                    ServiceTypeCode = "29",
                }
            };
        }

        [HttpPost]
        public void Post(HouseHoldSample sample)
        {
            throw new NotImplementedException();
        }
    }
}