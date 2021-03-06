﻿using System;
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
        [HttpGet]
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
                                    District = "เมือง",
                                    Tambon = "เมือง"
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
                                        WaterHeightCm = 2,
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
                                    District = "เมือง",
                                    Tambon = "เมือง"
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
                                    District = "เมือง",
                                    Tambon = "เมือง"
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
                                    District = "เมือง",
                                    Tambon = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 7,
                                    Ngan = 2,
                                    SqWa = 255
                                },
                                IrrigationField = false,
                                Plantings = new List<PlantItem>(){
                                    new PlantItem(){
                                        Code = "358",
                                        Name = "กล้วย"
                                    },
                                    new PlantItem(){
                                        Code = "951",
                                        Name = "แอ๊ปเปิ้ล"
                                    }
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
                    HerbsPlant = new PlantingInfo<MixablePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<MixablePlantingField>(){
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    Tambon = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 1,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Plantings = new List<PlantItem>(){
                                    new PlantItem(){
                                        Code = "165",
                                        Name = "พริกไทย"
                                    },
                                    new PlantItem(){
                                        Code = "366",
                                        Name = "คะน้า"
                                    }
                                },
                                ThisPlantOnly = false,
                                MixedWithPrimaryPlantCode = "778",
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
                                    District = "เมือง",
                                    Tambon = "เมือง"
                                },
                                Area = new Area(){
                                    Rai = 0,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Plantings = new List<PlantItem>(){
                                    new PlantItem(){
                                        Code = "117",
                                        Name = "หญ้าปสูนาม"
                                    },
                                    new PlantItem(){
                                        Code = "341",
                                        Name = "กล้วยไม้"
                                    }
                                },
                                ThisPlantOnly = false,
                                MixedWithPrimaryPlantCode = "665",
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
                    MushroomPlant = new PlantingInfo<MushroomField>()
                    {
                        Doing = true,
                        FieldCount = 1,
                        Fields = new List<MushroomField>(){
                            new MushroomField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    Tambon = "เมือง"
                                },
                                AreaSqM = 4,
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
                        Cow = new HasAndCount()
                        {
                            HasItem = true,
                            ItemCount = 2
                        },
                        Pig = new HasAndCount()
                        {
                            HasItem = true,
                            ItemCount = 5
                        },
                        Chicken = new HasAndCount()
                        {
                            HasItem = true,
                            ItemCount = 40
                        },
                        Duck = new HasAndCount()
                        {
                            HasItem = true,
                            ItemCount = 12
                        },
                        Other = new HasAndCount()
                        {
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
                        Shrimp = new FishFarming()
                        {
                            Doing = true,
                            Depression = true,
                            FieldCount = 3,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1
                                }
                            },
                            AnimalsCount = 1200,
                            WaterSources = new WaterSources()
                            {
                                Plumbing = true,
                                UnderGround = true,
                                Pool = false,
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
                        },
                        SnappingTurtle = new CrocodileFarming()
                        {
                            Doing = true,
                            Depression = false,
                            HasOther = true,
                            Other = "กะละมัง",
                            FieldCount = 3,
                            FieldsAreSameSize = false,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Circle,
                                    Diameter = 1,
                                    Depth = 1
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Circle,
                                    Diameter = 2,
                                    Depth = 1
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Circle,
                                    Diameter = 1,
                                    Depth = 2
                                }
                            },
                            AnimalsCount = 28,
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
                    BuildingCode = "431",
                    QuestionForAcademy = new Academy(){
                        PreSchool = new HasAndCount(){ HasItem = true, ItemCount = 7},
                        Kindergarten = new HasAndCount(){ HasItem = true, ItemCount = 12},
                        PrimarySchool = new HasAndCount(){ HasItem = true, ItemCount = 24},
                        HighSchool = new HasAndCount(){ HasItem = true, ItemCount = 33},
                        Vocational = new HasAndCount(){ HasItem = true, ItemCount = 46},
                        HigherEducation = new HasAndCount(){ HasItem = true, ItemCount = 19},
                        PersonnelCount = 15
                    },
                    HotelsAndResorts = new HotelsAndResorts(){ RoomCount = 35, PersonnelCount = 5},
                    Hospital = new Hospital(){ BedCount = 40, PersonnelCount = 25},
                    Building = new Building(){ RoomCount = 40, OccupiedRoomCount = 35, PersonnelCount = 3},
                    Religious = new Religious(){ PeopleCount = 7},                    
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
                            QualityProblem = new WaterProblem(){
                                HasProblem = true,
                                Problem = new Problem(){
                                    TurbidWater = false,
                                    SaltWater = true,
                                    Smell = false,
                                    FilmOfOil = false,
                                    FogWater = false,
                                    HardWater = false,
                                }
                            },
                            PlumbingUsage = new PlumbingUsage(){
                                WaterQuantity = WaterQuantity.WaterBill,
                                WaterBill = 956
                            }
                        },
                        WaterActivityPWA = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 0,
                            Agriculture = 0,
                            Product = 0,
                            Service = 0
                        },
                        WaterActivityMWA = new WaterActivity()
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
                        HasWaterNotRunning = false
                    },
                    GroundWater = new GroundWater()
                    {                        
                        PrivateGroundWater = new PrivateGroundWater(){
                            Doing = true,
                            AllCount = 1,
                            WaterResourceCount = 1,
                            WaterResources = new List<GroundWaterWell>(){
                                new GroundWaterWell(){
                                    UsageType = new GroundWaterUsage(){
                                        GroundWaterQuantity = GroundWaterQuantity.WaterBill,
                                        WaterBill = 578
                                    },
                                    HasPump = true,
                                    PumpCount = 1,
                                    Pumps = new List<Pump>(){
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 2,
                                            NumberOfPumpsPerYear = 340,
                                            HasPumpRate = true,
                                            PumpRate = 30,
                                            EnergySource = EnergySource.ElecticPump,
                                            PumpType = PumpType.DontKnowYet,
                                            HorsePower = 79.5,
                                            SuctionPipeSize = 3,
                                            PipelineSize = 2.5
                                        }
                                    },
                                    WaterActivities = new WaterActivity(){
                                        Drink = 0,
                                        Plant = 15,
                                        Farm = 0,
                                        Agriculture = 0,
                                        Product = 70,
                                        Service = 15
                                    },
                                    QualityProblem = new WaterProblem(){
                                        HasProblem = true,
                                        Problem = new Problem(){
                                            TurbidWater = true,
                                            SaltWater = false,
                                            Smell = false,
                                            FilmOfOil = false,
                                            FogWater = true,
                                            HardWater = true
                                        }
                                    }
                                }
                            }
                        },
                        PublicGroundWater = new PublicGroundWater(){
                            Doing = true,
                            WaterResourceCount = 1,
                            WaterResources = new List<WaterConsumptionUsingPumpBase>(){
                                new WaterConsumptionUsingPumpBase(){
                                    HasPump = true,
                                    PumpCount = 1,
                                    Pumps = new List<Pump>(){
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 8,
                                            NumberOfPumpsPerYear = 365,
                                            HasPumpRate = false,
                                            EnergySource = EnergySource.ElecticPump,
                                            PumpType = PumpType.DontKnowYet,
                                            HorsePower = 67,
                                            SuctionPipeSize = 4,
                                            PipelineSize = 2.5,
                                        }
                                    },
                                    WaterActivities = new WaterActivity(){
                                        Drink = 0,
                                        Plant = 40,
                                        Farm = 0,
                                        Agriculture = 40,
                                        Product = 0,
                                        Service = 20
                                    },
                                    QualityProblem = new WaterProblem(){
                                        HasProblem = true,
                                        Problem = new Problem(){
                                            TurbidWater = true,
                                            SaltWater = false,
                                            Smell = false,
                                            FilmOfOil = false,
                                            FogWater = false,
                                            HardWater = true
                                        }
                                    }
                                }
                            }
                        }
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
                                PumpRate = 6,
                                EnergySource = EnergySource.ElecticPump,
                                PumpType = PumpType.DontKnowYet,
                                HorsePower = 87,
                                SuctionPipeSize = 16,
                                PipelineSize = 24
                            }
                        },
                        WaterActivities = new WaterActivity()
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
                        Doing = true,
                        PoolCount = 1,
                        HasSameSize = true,
                        PoolSizes = new List<FieldSize>(){
                            new FieldSize(){
                                Shape = FieldShape.Circle,
                                Depth = 3,
                                Diameter = 25
                            }
                        },
                        WaterResourceCount = 1,
                        WaterResources = new List<WaterConsumptionUsingPump> {
                            new WaterConsumptionUsingPump(){
                                HasCubicMeterPerMonth = false,
                                HasPump = true,
                                PumpCount = 2,
                                Pumps = new List<Pump>(){
                                    new Pump(){
                                        PumpAuto = false,
                                        HoursPerPump = 5,
                                        NumberOfPumpsPerYear = 50,
                                        HasPumpRate = true,
                                        PumpRate = 40,
                                        EnergySource = EnergySource.ElecticPump,
                                        PumpType = PumpType.DontKnowYet,
                                        HorsePower = 110,
                                        SuctionPipeSize = 8,
                                        PipelineSize = 6
                                    },
                                    new Pump(){
                                        PumpAuto = false,
                                        HoursPerPump = 4,
                                        NumberOfPumpsPerYear = 70,
                                        HasPumpRate = true,
                                        PumpRate = 60,
                                        EnergySource = EnergySource.ElecticPump,
                                        PumpType = PumpType.DontKnowYet,
                                        HorsePower = 100,
                                        SuctionPipeSize = 6,
                                        PipelineSize = 4
                                    }
                                },
                                WaterActivities = new WaterActivity(){
                                    Drink = 0,
                                    Plant = 20,
                                    Farm = 60,
                                    Agriculture = 20,
                                    Product = 0,
                                    Service = 0
                                },
                                QualityProblem = new WaterProblem(){
                                    HasProblem = true,
                                    Problem = new Problem(){
                                        TurbidWater = true,
                                        SaltWater = false,
                                        Smell = false,
                                        FilmOfOil = false,
                                        FogWater = false,
                                        HardWater = false
                                    }
                                }
                            }
                        }
                    },
                    Irrigation = new Irrigation()
                    {
                        CubicMeterPerMonth = 75,
                        HasPump = false,
                        WaterActivities = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 5,
                            Farm = 0,
                            Agriculture = 0,
                            Product = 80,
                            Service = 15
                        },
                        QualityProblem = new WaterProblem()
                        {
                            HasProblem = false
                        }
                    },
                    Rain = new Rain()
                    {
                        RainContainers = new List<RainContainer>
                        {
                            new RainContainer() {
                                Category = "โอ่ง",
                                Size = 1000,
                                Count = 5
                            }
                        },
                    WaterActivities = new WaterActivity()
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

        [Route("building")]
        [HttpGet]
        public ActionResult<BuildingSample> GetBuilding() {
            return new BuildingSample();
        }

        [Route("community")]
        [HttpGet]
        public ActionResult<CommunitySample> GetCommunity() {
            return new CommunitySample();
        }

        [HttpPost]
        public void Post(HouseHoldSample sample)
        {
            throw new NotImplementedException();
        }
    }
}