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
        [HttpGet]
        public ActionResult<HouseHoldSample> Get()
        {
            return new HouseHoldSample()
            {
                _id = "1234",
                EA = "AA04S",
                BuildingId = "1150AWQ",
                SubUnit = new SubUnit()
                {
                    RoomNumber = "77B",
                    AccessCount =  0,
                    Accesses = new List<Access>(){
                        Access.HasPersonAndAccept,
                        Access.HasPersonAndAccept,
                        Access.HasPersonAndAccept,
                    },     
                    HasPlumbing = true,
                    HasPlumbingMeter = true,
                    IsPlumbingMeterXWA = true,
                    HasGroundWater = true,
                    HasGroundWaterMeter = true,
                },
                IsHouseHold = true,
                IsAgriculture = true,
                IsFactorial = true,
                IsCommercial = true,
                Comments = new List<Comment>(){
                    new Comment(){
                        At = DateTime.Now,
                        Text = "Good Man" ,
                    },
                    new Comment(){
                        At = DateTime.Now,
                        Text = "Good Man" ,
                    },
                    new Comment(){
                        At = DateTime.Now,
                        Text = "Good Man" ,
                    },
                },
                Residence = new Residential()
                {
                    MemberCount = 5,
                    WorkingAge = 2,
                    WaterSources = new WaterSources()
                    {
                        Plumbing = true,
                        UnderGround = true,
                        Pool = true,
                        River = true,
                        Irrigation = true,
                        Rain = true,
                        Buying = true,
                        HasOther = true,
                        Other = "no"
                    },
                    GardeningUse = true
                },
                Agriculture = new Agriculture()
                {
                    RicePlant = new PlantingInfo<RicePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<RicePlantingField>(){
                            new RicePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
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
                                IrrigationField = true,
                                WaterSources = new WaterSources(){
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    Buying = true,
                                    RainingAsIs = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new RicePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    AgronomyPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<GrowingFieldWithNames>(){
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 5,
                                    Ngan = 2,
                                    SqWa = 78,
                                },
                                IrrigationField = true,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "232",
                                            Name = "ยาสูบ"
                                        },
                                         new Plant(){
                                            Code = "323",
                                            Name = "แตงโม"
                                        }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 5,
                                    Ngan = 2,
                                    SqWa = 78,
                                },
                                IrrigationField = false,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "232",
                                            Name = "ยาสูบ"
                                        },
                                         new Plant(){
                                            Code = "323",
                                            Name = "แตงโม"
                                        }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    RubberTree = new PlantingInfo<GrowingField>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<GrowingField>(){
                            new GrowingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 15,
                                    Ngan = 3,
                                    SqWa = 300
                                },
                                IrrigationField = true,
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new GrowingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    PerennialPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<GrowingFieldWithNames>(){
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 7,
                                    Ngan = 2,
                                    SqWa = 255
                                },
                                IrrigationField = true,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "232",
                                            Name = "ยาสูบ"
                                        },
                                         new Plant(){
                                            Code = "323",
                                            Name = "แตงโม"
                                        }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new GrowingFieldWithNames(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 7,
                                    Ngan = 2,
                                    SqWa = 255
                                },
                                IrrigationField = false,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "232",
                                            Name = "ยาสูบ"
                                        },
                                         new Plant(){
                                            Code = "323",
                                            Name = "แตงโม"
                                        }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    HerbsPlant = new PlantingInfo<MixablePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<MixablePlantingField>(){
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 1,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = true,
                                    Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                       new Plant()
                                            {
                                                Code = "165",
                                                Name = "พริกไทย"
                                            },
                                            new Plant()
                                            {
                                                Code = "366",
                                                Name = "คะน้า"
                                            }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                            Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                ThisPlantOnly = true,
                                 PrimaryPlant = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                          Code = "366",
                                        Name = "คะน้า"
                                        }
                                    }
                                },
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 1,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                       new Plant()
                                            {
                                                Code = "165",
                                                Name = "พริกไทย"
                                            },
                                            new Plant()
                                            {
                                                Code = "366",
                                                Name = "คะน้า"
                                            }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                ThisPlantOnly = false,
                                PrimaryPlant = new PlantItem()
                                {
                                    PlantingCount = 1,
                                    Plants = new List<Plant>()
                                    {
                                        new Plant()
                                        {
                                            Code = "341",
                                            Name = "กล้วยไม้"
                                        }
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    FlowerCrop = new PlantingInfo<MixablePlantingField>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<MixablePlantingField>(){
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 0,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = true,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                       new Plant()
                                            {
                                                Code = "117",
                                                Name = "หญ้าปสูนาม"
                                            },
                                            new Plant()
                                            {
                                                Code = "341",
                                                Name = "กล้วยไม้"
                                            }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                ThisPlantOnly = true,
                                PrimaryPlant = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                          Code = "366",
                                        Name = "คะน้า"
                                        }
                                    }
                                },
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new MixablePlantingField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                Area = new Area(){
                                    Rai = 0,
                                    Ngan = 0,
                                    SqWa = 25
                                },
                                IrrigationField = false,
                                Plantings = new PlantItem(){
                                    PlantingCount = 2,
                                    Plants = new List<Plant>(){
                                       new Plant()
                                            {
                                                Code = "117",
                                                Name = "หญ้าปสูนาม"
                                            },
                                            new Plant()
                                            {
                                                Code = "341",
                                                Name = "กล้วยไม้"
                                            }
                                    }
                                },
                                OtherPlantings = new PlantItem(){
                                    PlantingCount = 1,
                                    Plants = new List<Plant>(){
                                        new Plant(){
                                            Code = "3001",
                                                Name = "ยาสูบชนิดใหม่"
                                        }
                                    }
                                },
                                ThisPlantOnly = false,
                                PrimaryPlant = new PlantItem()
                                {
                                    PlantingCount = 1,
                                    Plants = new List<Plant>()
                                    {
                                        new Plant()
                                        {
                                            Code = "341",
                                            Name = "กล้วยไม้"
                                        }
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
                                    HasOther = false,
                                    Other = "no"
                                }
                            }
                        }
                    },
                    MushroomPlant = new PlantingInfo<MushroomField>()
                    {
                        Doing = true,
                        FieldCount = 2,
                        Fields = new List<MushroomField>(){
                            new MushroomField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
                                },
                                AreaSqM = 4,
                                IrrigationField = true,
                                WaterSources = new WaterSources(){
                                    Plumbing = true,
                                    UnderGround = true,
                                    Pool = true,
                                    River = true,
                                    Irrigation = true,
                                    Rain = true,
                                    RainingAsIs = true,
                                    Buying = true,
                                    HasOther = true,
                                    Other = "no"
                                }
                            },
                            new MushroomField(){
                                Location = new Location(){
                                    Province = "ขอนแก่น",
                                    District = "เมือง",
                                    SubDistrict = "ในเมือง"
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
                                    HasOther = false,
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
                        Buffalo = new HasAndCount()
                        {
                            HasItem = false,
                            ItemCount = 0
                        },
                        Pig = new HasAndCount()
                        {
                            HasItem = true,
                            ItemCount = 5
                        },
                        Goat = new HasAndCount()
                        {
                            HasItem = false,
                            ItemCount = 0
                        },
                        Sheep = new HasAndCount()
                        {
                            HasItem = false,
                            ItemCount = 0
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
                        Goose = new HasAndCount()
                        {
                            HasItem = false,
                            ItemCount = 0
                        },
                        SilkWool = new HasAndCount()
                        {
                            HasItem = false,
                            ItemCount = 0
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
                            HasOther = false,
                            Other = "no"
                        }
                    },
                    AquaticAnimals = new AquaticAnimals()
                    {
                        Doing = true,
                        IsFish = true,
                        Fish = new FishFarming()
                        {
                            Doing = true,
                            Depression = true,
                            GardenGroove = false,
                            Stew = true,
                            RiceField = false,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 2,
                            FieldsAreSameSize = false,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Area,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                     Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 2,
                                    Diameter = 1
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Area,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                     Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 2,
                                    Diameter = 1
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
                                Buying = false,
                                RainingAsIs = true,
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsShrimp = true,
                        Shrimp = new FishFarming()
                        {
                            Doing = true,
                            Depression = false,
                            GardenGroove = false,
                            Stew = true,
                            RiceField = false,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 3,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsFrog = true,
                        Frog = new FrogFarming()
                        {
                            Doing = true,
                            Depression = true,
                            Stew = false,
                            HasOther = false,
                            Other = "คันแทนา",
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsCrocodile = true,
                        Crocodile = new CrocodileFarming()
                        {
                            Doing = true,
                            Depression = true,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 2,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 8,
                                    },
                                    Depth = 4,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 8,
                                    },
                                    Depth = 4,
                                    Diameter = 1,
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsSnappingTurtle = true,
                        SnappingTurtle = new CrocodileFarming()
                        {
                            Doing = true,
                            Depression = true,
                            HasOther = true,
                            Other = "กะละมัง",
                            FieldCount = 1,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Circle,
                                    Area = new Area(){
                                        Rai = 3,
                                        Ngan = 3,
                                        SqWa = 18,
                                    },
                                      Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 8,
                                    },
                                    Diameter = 1,
                                    Depth = 1
                                },
                            },
                            AnimalsCount = 28,
                            WaterSources = new WaterSources()
                            {
                                Plumbing = true,
                                UnderGround = true,
                                Pool = true,
                                River = true,
                                Irrigation = true,
                                Rain = true,
                                RainingAsIs = true,
                                Buying = false,
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsCrab = true,
                        Crab = new FishFarming()
                        {
                            Doing = true,
                            Depression = false,
                            GardenGroove = false,
                            Stew = true,
                            RiceField = false,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 3,
                            FieldsAreSameSize = false,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 5,
                                        Ngan = 2,
                                        SqWa = 15,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 1,
                                        Ngan = 2,
                                        SqWa = 10,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsShellFish = true,
                        ShellFish = new FishFarming()
                        {
                            Doing = true,
                            Depression = true,
                            GardenGroove = false,
                            Stew = true,
                            RiceField = false,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 3,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsTurtle = true,
                        Turtle = new CrocodileFarming()
                        {
                            Doing = true,
                            Depression = true,
                            HasOther = true,
                            Other = "กะละมัง",
                            FieldCount = 1,
                            FieldsAreSameSize = true,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Circle,
                                    Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                      Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 8,
                                    },
                                    Diameter = 1,
                                    Depth = 1
                                },
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
                                HasOther = false,
                                Other = "no"
                            }
                        },
                        IsReddish = true,
                        Reddish = new FishFarming()
                        {
                            Doing = true,
                            Depression = true,
                            GardenGroove = false,
                            Stew = true,
                            RiceField = false,
                            HasOther = false,
                            Other = "คันแทนา",
                            FieldCount = 3,
                            FieldsAreSameSize = false,
                            Fields = new List<FieldSize>(){
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
                                },
                                new FieldSize(){
                                    Shape = FieldShape.Rectangle,
                                     Area = new Area(){
                                        Rai = 0,
                                        Ngan = 0,
                                        SqWa = 18,
                                    },
                                    Rectangle = new RectanglePool(){
                                        Width = 5,
                                        Length = 4
                                    },
                                    Depth = 1,
                                    Diameter = 1,
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
                                HasOther = false,
                                Other = "no"

                            },
                        },
                    }
                },
                Factory = new Factorial()
                {
                    Name = "บ้านมอนด์",
                    Category = "ขนม",
                    WorkersCount = 500,
                    HeavyMachine = true,
                    WaterSources = new WaterSources()
                    {
                        Plumbing = false,
                        UnderGround = false,
                        Pool = false,
                        River = true,
                        Irrigation = true,
                        Rain = true,
                        Buying = true,
                        HasOther = true,
                        Other = "ภูเขาไฟ"
                    },
                    HasWasteWaterFromProduction = false,
                    HasWasteWaterTreatment = false,
                    WasteWaterReuse = true
                },
                Commerce = new Commercial()
                {
                    Name = "บ้านมอนด์",
                    ServiceType = "โรงเรียน",
                    BuildingCode = BuildingType.Office,
                    QuestionForAcademy = new Academy()
                    {
                        PreSchool = new HasAndCount() { HasItem = true, ItemCount = 8 },
                        Kindergarten = new HasAndCount() { HasItem = true, ItemCount = 13 },
                        PrimarySchool = new HasAndCount() { HasItem = true, ItemCount = 29 },
                        HighSchool = new HasAndCount() { HasItem = true, ItemCount = 20 },
                        Vocational = new HasAndCount() { HasItem = true, ItemCount = 35 },
                        HigherEducation = new HasAndCount() { HasItem = true, ItemCount = 25 },
                        PersonnelCount = 25
                    },
                    HotelsAndResorts = new HotelsAndResorts() { RoomCount = 23, PersonnelCount = 6 },
                    Hospital = new Hospital() { BedCount = 50, PersonnelCount = 30 },
                    Building = new Building() { RoomCount = 50, OccupiedRoomCount = 31, PersonnelCount = 8 },
                    Religious = new Religious() { PeopleCount = 6 },
                    OtherBuilding = new OtherBuilding()
                    {
                        PersonnelCount = 8,
                    },
                    WaterSources = new WaterSources()
                    {
                        Plumbing = true,
                        UnderGround = false,
                        Pool = true,
                        River = false,
                        Irrigation = false,
                        Rain = false,
                        Buying = true,
                        HasOther = true,
                        Other = "ภูเขา"
                    }
                },
                WaterUsage = new WaterUsage()
                {
                    Plumbing = new Plumbing()
                    {
                        MWA = new PlumbingInfo()
                        {
                            Doing = true,
                            PlumbingUsage = new PlumbingUsage()
                            {
                                WaterQuantity = WaterQuantity.CubicMeterPerMonth,
                                CubicMeterPerMonth = 10,
                                WaterBill = 4
                            },
                            QualityProblem = new WaterProblem()
                            {
                                HasProblem = false,
                                Problem = new Problem()
                                {
                                    FilmOfOil = true,
                                    FogWater = true,
                                    HardWater = false,
                                    SaltWater = false,
                                    Smell = true,
                                    TurbidWater = true,
                                }
                            }
                        },
                        PWA = new PlumbingInfo()
                        {
                            Doing = true,
                            PlumbingUsage = new PlumbingUsage()
                            {
                                WaterQuantity = WaterQuantity.UnknowNoMeter,
                                CubicMeterPerMonth = 5,
                                WaterBill = 50,
                            },
                            QualityProblem = new WaterProblem()
                            {
                                HasProblem = false,
                                Problem = new Problem()
                                {
                                    FilmOfOil = false,
                                    FogWater = false,
                                    HardWater = true,
                                    SaltWater = true,
                                    Smell = true,
                                    TurbidWater = true,
                                }
                            }
                        },
                        Other = new PlumbingInfo()
                        {
                            Doing = true,
                            QualityProblem = new WaterProblem()
                            {
                                HasProblem = false,
                                Problem = new Problem()
                                {
                                    TurbidWater = false,
                                    SaltWater = true,
                                    Smell = false,
                                    FilmOfOil = false,
                                    FogWater = true,
                                    HardWater = false,
                                }
                            },
                            PlumbingUsage = new PlumbingUsage()
                            {
                                WaterQuantity = WaterQuantity.UnknowExcepted,
                                CubicMeterPerMonth = 10,
                                WaterBill = 956,

                            }
                        },
                        WaterActivityPWA = new WaterActivity()
                        {
                            Drink = 20,
                            Plant = 20,
                            Agriculture = 20,
                            Product = 20,
                            Service = 20
                        },
                        WaterActivityMWA = new WaterActivity()
                        {
                            Drink = 20,
                            Plant = 20,
                            Agriculture = 20,
                            Product = 10,
                            Service = 30
                        },
                        WaterActivityOther = new WaterActivity()
                        {
                            Drink = 5,
                            Plant = 5,
                            Agriculture = 5,
                            Product = 80,
                            Service = 5
                        },
                        HasWaterNotRunning = true,
                    },
                    GroundWater = new GroundWater()
                    {
                        PrivateGroundWater = new PrivateGroundWater()
                        {
                            Doing = true,
                            AllCount = 3,
                            WaterResourceCount = 2,
                            WaterResources = new List<GroundWaterWell>(){
                                new GroundWaterWell(){
                                    UsageType = new GroundWaterUsage(){
                                        GroundWaterQuantity = GroundWaterQuantity.CubicMeterPerMonth,
                                        UsageCubicMeters = 3000,
                                        WaterBill = 1500,
                                    },
                                    HasPump = true,
                                    PumpCount = 2,
                                    Pumps = new List<Pump>(){
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 5,
                                            NumberOfPumpsPerYear = 500,
                                            HasPumpRate = false,
                                            PumpRate = 50,
                                            EnergySource = EnergySource.PetrolPump,
                                            PumpType = PumpType.PayanakPump,
                                            HorsePower = HorsePower.W10001_14000H15_20,
                                            SuctionPipeSize = SuctionPipeSize.SP1,
                                            PipelineSize = PipelineSize.PS1,
                                        },
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 8,
                                            NumberOfPumpsPerYear = 1500,
                                            HasPumpRate = true,
                                            PumpRate = 80,
                                            EnergySource = EnergySource.TwoWheeledTractors,
                                            PumpType = PumpType.PayanakPump,
                                            HorsePower = HorsePower.W10001_12000H14_16,
                                            SuctionPipeSize = SuctionPipeSize.SP112_2,
                                            PipelineSize = PipelineSize.PS112_2,
                                        }
                                    },
                                    WaterActivities = new WaterActivity(){
                                        Drink = 5,
                                        Plant = 5,
                                        Farm = 5,
                                        Agriculture = 10,
                                        Product = 60,
                                        Service = 15
                                    },
                                    QualityProblem = new WaterProblem(){
                                       HasProblem = false,
                                        Problem = new Problem(){
                                            TurbidWater = true,
                                            SaltWater = false,
                                            Smell = false,
                                            FilmOfOil = false,
                                            FogWater = true,
                                            HardWater = true
                                        }

                                    }
                                },
                                 new GroundWaterWell(){
                                    UsageType = new GroundWaterUsage(){
                                        GroundWaterQuantity = GroundWaterQuantity.WaterBill,
                                        UsageCubicMeters = 5000,
                                        WaterBill = 300,
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
                                            PumpType = PumpType.PayanakPump,
                                            HorsePower = HorsePower.W10001_12000H14_16,
                                            SuctionPipeSize = SuctionPipeSize.SP112_2,
                                            PipelineSize = PipelineSize.PS112_2,
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
                                            SaltWater = true,
                                            Smell = true,
                                            FilmOfOil = true,
                                            FogWater = true,
                                            HardWater = true
                                        }

                                    }
                                },

                            }
                        },
                        PublicGroundWater = new PublicGroundWater()
                        {
                            Doing = true,
                            WaterResourceCount = 1,
                            WaterResources = new List<WaterConsumptionUsingPump>(){
                                new WaterConsumptionUsingPump(){
                                    HasCubicMeterPerMonth = true,
                                    CubicMeterPerMonth = 3,
                                    HasPump = false,
                                    PumpCount = 2,
                                    Pumps = new List<Pump>(){
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 8,
                                            NumberOfPumpsPerYear = 365,
                                            HasPumpRate = true,
                                            EnergySource = EnergySource.PetrolPump,
                                            PumpType = PumpType.PayanakPump,
                                            HorsePower = HorsePower.W10001_14000H15_25,
                                            SuctionPipeSize = SuctionPipeSize.SP12_3,
                                            PipelineSize = PipelineSize.PS4_8,
                                            PumpRate = 0
                                        },
                                        new Pump(){
                                            PumpAuto = false,
                                            HoursPerPump = 30,
                                            NumberOfPumpsPerYear = 500,
                                            HasPumpRate = false,
                                            EnergySource = EnergySource.ElecticPump,
                                            PumpType = PumpType.PayanakPump,
                                            HorsePower = HorsePower.W25001_30000H35_40,
                                            SuctionPipeSize = SuctionPipeSize.SP12_1,
                                            PipelineSize = PipelineSize.PS12_3,
                                            PumpRate = 0
                                        }
                                    },
                                    WaterActivities = new WaterActivity(){
                                        Drink = 20,
                                        Plant = 40,
                                        Farm = 20,
                                        Agriculture = 20,
                                        Product = 10,
                                        Service = 10,
                                    },
                                    QualityProblem = new WaterProblem(){
                                        HasProblem = true,
                                        Problem = new Problem(){
                                            TurbidWater = true,
                                            SaltWater = true,
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
                        PumpCount = 3,
                        Pumps = new List<Pump>(){
                            new Pump(){
                                PumpAuto = true,
                                HoursPerPump = 10,
                                NumberOfPumpsPerYear = 300,
                                PumpRate = 6,
                                EnergySource = EnergySource.ElecticPump,
                                PumpType = PumpType.PayanakPump,
                                HorsePower = HorsePower.W200_300H02_04,
                                SuctionPipeSize = SuctionPipeSize.SP12_3,
                                PipelineSize = PipelineSize.PS112_3,
                            },
                            new Pump(){
                                PumpAuto = false,
                                HoursPerPump = 2,
                                NumberOfPumpsPerYear = 224,
                                PumpRate = 6,
                                EnergySource = EnergySource.PetrolPump,
                                PumpType = PumpType.PayanakPump,
                                HorsePower = HorsePower.W20001_25000H25_35,
                                SuctionPipeSize = SuctionPipeSize.SP12_1,
                                PipelineSize = PipelineSize.PS12_4,
                            },
                             new Pump(){
                                PumpAuto = false,
                                HoursPerPump = 8,
                                NumberOfPumpsPerYear = 1000,
                                PumpRate = 6,
                                EnergySource = EnergySource.TwoWheeledTractors,
                                PumpType = PumpType.PayanakPump,
                                HorsePower = HorsePower.W14000_18000H19_24,
                                SuctionPipeSize = SuctionPipeSize.SP12_6,
                                PipelineSize = PipelineSize.PS4_8,
                            },
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
                                TurbidWater = true,
                                SaltWater = true,
                                Smell = false,
                                FilmOfOil = true,
                                FogWater = false,
                                HardWater = true

                            }
                        }
                    },
                    Pool = new Pool()
                    {
                        Doing = true,
                        PoolCount = 2,
                        HasSameSize = false,
                        PoolSizes = new List<FieldSize>(){
                            new FieldSize(){
                                Shape = FieldShape.Rectangle,
                                Area = new Area()
                                {
                                    Rai = 2,
                                    Ngan = 1,
                                    SqWa = 300
                                },
                                Depth = 3,
                                Rectangle = new RectanglePool()
                                {
                                    Width = 0,
                                    Length = 0
                                },
                                Diameter = 25
                            },
                             new FieldSize(){
                                Shape = FieldShape.Circle,
                                Area = new Area()
                                {
                                    Rai = 2,
                                    Ngan = 1,
                                    SqWa = 300
                                },
                                Depth = 3,
                                Rectangle = new RectanglePool()
                                {
                                    Width = 0,
                                    Length = 0
                                },
                                Diameter = 25
                            }
                        },
                        WaterResourceCount = 1,
                        WaterResources = new List<WaterConsumptionUsingPump> {
                            new WaterConsumptionUsingPump(){
                                HasCubicMeterPerMonth = true,
                                CubicMeterPerMonth = 55,
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
                                        PumpType = PumpType.PayanakPump,
                                        HorsePower = HorsePower.W14000_18000H19_24,
                                        SuctionPipeSize = SuctionPipeSize.SP12_3,
                                        PipelineSize = PipelineSize.PS3,
                                    },
                                    new Pump(){
                                        PumpAuto = false,
                                        HoursPerPump = 4,
                                        NumberOfPumpsPerYear = 70,
                                        HasPumpRate = true,
                                        PumpRate = 60,
                                        EnergySource = EnergySource.ElecticPump,
                                        PumpType = PumpType.PayanakPump,
                                        HorsePower = HorsePower.W11001_12000H15_16,
                                        SuctionPipeSize = SuctionPipeSize.SP11_12,
                                        PipelineSize = PipelineSize.PS112_2,
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
                                    HasProblem = false,
                                    Problem = new Problem(){
                                        TurbidWater = false,
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
                    Irrigation = new Irrigation()
                    {
                        HasCubicMeterPerMonth = true,
                        CubicMeterPerMonth = 150,
                        HasPump = true,
                        PumpCount = 2,
                        Pumps = new List<Pump>()
                        {
                            new Pump(){
                                 PumpAuto = false,
                                 HoursPerPump = 4,
                                 NumberOfPumpsPerYear = 70,
                                 HasPumpRate = true,
                                 PumpRate = 60,
                                 EnergySource = EnergySource.ElecticPump,
                                 PumpType = PumpType.PayanakPump,
                                 HorsePower = HorsePower.W1000_2500H1_3,
                                 SuctionPipeSize = SuctionPipeSize.SP12_112,
                                 PipelineSize = PipelineSize.PS12_112
                            },
                            new Pump(){
                                 PumpAuto = true,
                                 HoursPerPump = 16,
                                 NumberOfPumpsPerYear = 200,
                                 HasPumpRate = false,
                                 PumpRate = 120,
                                 EnergySource = EnergySource.ElecticPump,
                                 PumpType = PumpType.PayanakPump,
                                 HorsePower = HorsePower.W100_200H01_02,
                                 SuctionPipeSize = SuctionPipeSize.SP12_3,
                                 PipelineSize = PipelineSize.PS112,
                            }
                        },
                        WaterActivities = new WaterActivity()
                        {
                            Drink = 0,
                            Plant = 5,
                            Farm = 10,
                            Agriculture = 0,
                            Product = 70,
                            Service = 15
                        },
                        QualityProblem = new WaterProblem()
                        {
                            HasProblem = true,
                            Problem = new Problem()
                            {
                                TurbidWater = true,
                                SaltWater = false,
                                Smell = false,
                                FilmOfOil = true,
                                FogWater = true,
                                HardWater = true
                            }
                        }
                    },
                    Rain = new Rain()
                    {
                        RainContainers = new List<RainContainer>
                        {
                            new RainContainer() {
                                Category = "โอ่งมังกร",
                                Size = 1500,
                                Count = 15
                            }
                        },
                        WaterActivities = new WaterActivity()
                        {
                            Drink = 50,
                            Plant = 5,
                            Agriculture = 10,
                            Product = 20,
                            Service = 15
                        }
                    },
                    Buying = new Buying()
                    {
                        Package = new List<Package>(){
                        new Package(){
                            Name = "ขวด",
                            Size = 2,
                            Drink = 200,
                            Agriculture = 100 ,
                            Factory = 200 ,
                            Service = 300 ,

                        },
                        new Package(){
                            Name = "ถัง",
                            Size = 3,
                            Drink = 300,
                            Agriculture = 100 ,
                            Factory = 200 ,
                            Service = 300 ,
                        },
                        new Package(){
                            Name = "แทงค์",
                            Size = 1,
                            Drink = 500,
                            Agriculture = 100 ,
                            Factory = 200 ,
                            Service = 300 ,
                        },
                        new Package(){
                            Name = "รถ",
                            Size = 6,
                            Drink = 150,
                            Agriculture = 100 ,
                            Factory = 200 ,
                            Service = 300 ,
                        },
                        new Package(){
                            Name = "รถถัง",
                            Size = 5,
                            Drink = 50,
                            Agriculture = 100 ,
                            Factory = 200 ,
                            Service = 300 ,
                        },
                    }
                    }
                },
                Disaster = new Disasterous()
                {
                    Flooded = true,
                    YearsDisasterous = new List<YearsDisasterous>()
                    {
                        new YearsDisasterous()
                        {
                            Year = 1999,
                            Count = 2,
                            AvgDay = 2,
                            AvgHour = 5,
                            WaterHeightCm = 3
                        },
                        new YearsDisasterous()
                        {
                            Year = 1999,
                            Count = 5,
                            AvgDay = 4,
                            AvgHour = 2,
                            WaterHeightCm = 5
                        },
                        new YearsDisasterous()
                        {
                            Year = 2009,
                            Count = 1,
                            AvgDay = 2,
                            AvgHour = 1,
                            WaterHeightCm = 2
                        },
                        new YearsDisasterous()
                        {
                            Year = 2010,
                            Count = 5,
                            AvgDay = 2,
                            AvgHour = 2,
                            WaterHeightCm = 1
                        },
                        new YearsDisasterous()
                        {
                            Year = 2012,
                            Count = 2,
                            AvgDay = 2,
                            AvgHour = 5,
                            WaterHeightCm = 1
                        }
                    }
                },
                Population = new Population(){
                    PersonCount = 3,
                    Persons = new List<Person>(){
                        new Person(){
                            NameTitle = NameTitle.Mister,
                            FirstName = "Sorr",
                            LastName = "Na",
                            Relationship = Relationship.HeadFamily,
                            Sex = Sex.Male,
                            Age = 25,
                            Nationality = Nationality.Thai_764,
                            Registration = Registration.InThisHouse
                        },
                        new Person(){
                            NameTitle = NameTitle.Lessie,
                            FirstName = "Nerd",
                            LastName = "OK",
                            Relationship = Relationship.Tenant,
                            Sex = Sex.Female,
                            Age = 19,
                            Nationality = Nationality.Myanmar_2,
                            Registration = Registration.NoThisHouseOtherProvince,
                            OtherProvince = "Yala"
                        },
                        new Person(){
                            NameTitle = NameTitle.Master,
                            FirstName = "O",
                            LastName = "0",
                            Relationship = Relationship.Relative,
                            Sex = Sex.Male,
                            Age = 20,
                            Nationality = Nationality.NoNationality_998,
                            Registration = Registration.NotInThailand
                        }
                    }
                },
                Closing = new ClosingInfo()
                {
                    Informer = "DoreamonDiaDomonBarbgon",
                    FactorialCategoryCode = FactorialCategory.ArtificialMetal,
                    ServiceTypeCode = ServiceType.Accommodation,
                }
            };
        }

        [Route("building")]
        [HttpGet]
        public ActionResult<BuildingSample> GetBuilding()
        {
            return new BuildingSample()
            {
                _id = "Kitty1234",
                EA = "5678842",
                Ordering = 1,
                Road = "ถนนลาดยาง",
                Alley = "ซอยลูกรัง",
                Name = "บ้านซอ",
                HouseNo = "999/8",
                Latitude = 16.482835,
                Longitude = 102.819165,
                BuildingType = BuildingType.Factory,
                Other = "no",
                Access = BuildingAccess.HasPersonAndAccept,
                VacancyCount = 3,
                AbandonedCount = 5,
                UnitCount = 12,
                UnitAccess = UnitAccess.NotAllowGiveInfo,
                VacantRoomCount = 6,
                OccupiedRoomCount = 6,
                WaterQuantity = new PlumbingUsage()
                {
                    WaterQuantity = WaterQuantity.WaterBill,
                    CubicMeterPerMonth = 142,
                    WaterBill = 243,
                },
                FloorCount = 2,
                Comments = new List<Comment>(){
                    new Comment(){
                        At = DateTime.Now,
                        Text = "บ้านนี้หมาดุ"
                    }
                },
                RecCtrl = new RecordControl()
                {
                    CreatedDateTime = DateTime.Now,
                    LastModified = DateTime.Now,
                    DeletedDateTime = DateTime.Now,
                    LastUpload = DateTime.Now,
                    LastDownload = DateTime.Now,
                    Logs = new List<RecordControlLog>(){
                        new RecordControlLog(){
                            At = DateTime.Now,
                            OperationCode = "77AAB"
                        }
                    }
                }
            };
        }

        [Route("community")]
        [HttpGet]
        public ActionResult<CommunitySample> GetCommunity()
        {
            return new CommunitySample()
            {
                Management = new CommunityWaterManagement()
                {
                    HasPublicWater = true,
                    PublicWaterCount = 2,
                    Details = new List<DetailWaterManagement>(){
                        new DetailWaterManagement(){
                            Name = "หนองหญ้าเขียว",
                            UseForPlumbing = true,
                            UseForFactory = true,
                            UseForFarming = true,
                            UseForService = true,
                            UseForOther = true,
                            Other = "no",
                            ProjectArea = new FieldSize(){
                                Shape = FieldShape.Rectangle,
                                Area = new Area(){
                                    Rai = 362,
                                    Ngan = 2,
                                    SqWa = 132
                                },
                                Depth = 3,
                                Rectangle = new RectanglePool(){
                                    Width = 278,
                                    Length = 214
                                },
                                Diameter = 0
                            }
                        },
                        new DetailWaterManagement(){
                            Name = "สระดินดำ",
                            UseForPlumbing = true,
                            UseForFactory = true,
                            UseForFarming = true,
                            UseForService = true,
                            UseForOther = true,
                            Other = "no",
                            ProjectArea = new FieldSize(){
                                Shape = FieldShape.Rectangle,
                                Area = new Area(){
                                    Rai = 14,
                                    Ngan = 2,
                                    SqWa = 31
                                },
                                Depth = 2,
                                Rectangle = new RectanglePool(){
                                    Width = 56,
                                    Length = 41
                                },
                                Diameter = 0
                            }
                        }
                    },
                    PWA = true,
                    MWA = false,
                    OtherPlumbing = true,
                    HasWaterService = true,
                    WaterServiceCount = 2,
                    WaterServices = new List<DetailOrgWaterSupply>(){
                        new DetailOrgWaterSupply(){
                            Name = "ปะปาบ้านซอ",
                            HasSurfaceWater = true,
                            SurfaceWaterPerMonth = 2000,
                            UseGroundWater = true,
                            GroundWaterCount = 2,
                            GroundWaterUsePerMonth = 200,
                            PlumbingPrice = 2,
                            MeterRentalFee = 300,
                            Disinfection = DisinfectionMethod.Other,
                            OtherDisinfection = "no"
                        },
                        new DetailOrgWaterSupply(){
                            Name = "ปะปาวัด",
                            HasSurfaceWater = true,
                            SurfaceWaterPerMonth = 1000,
                            UseGroundWater = true,
                            GroundWaterCount = 1,
                            GroundWaterUsePerMonth = 50,
                            PlumbingPrice = 2,
                            MeterRentalFee = 100,
                            Disinfection = DisinfectionMethod.Other,
                            OtherDisinfection = "no"
                        }
                    },
                    HasWaterTreatment = true,
                    HasDisaster = true,
                    Disasters = new NaturalDisaster()
                    {
                        Tsunami = false,
                        LandSlide = false,
                        Earthquake = false,
                        Cyclone = true,
                        ForestFire = true,
                        Drought = true,
                        Cold = true,
                        Epidemic = false,
                        Pest = true,
                        Epizootics = false
                    },
                    HasDisasterWarning = true,
                    DisasterWarningMethods = new DisasterWarningMethod()
                    {
                        GovernmentProcess = true,
                        CommunityPlan = true,
                        ConsultingService = true,
                        HasOther = true,
                        Other = "yes"
                    }
                },
                CommunityProject = new ManagementForFarming()
                {
                    Doing = true,
                    ProjectCount = 2,
                    Details = new List<DetailManagementForFarming>(){
                        new DetailManagementForFarming(){
                            Name = "น้ำเพื่อชีวิต",
                            Area = new Area(){
                                Rai = 44,
                                Ngan = 1,
                                SqWa = 324
                            },
                            MemberCount = 324,
                            AvgGroundWaterUse = 3500,
                            GroundWaterCount = 2,
                            AvgSurfaceWaterUse = 500
                        },
                        new DetailManagementForFarming(){
                            Name = "น้ำเพื่อผักกาด",
                            Area = new Area(){
                                Rai = 58,
                                Ngan = 3,
                                SqWa = 52
                            },
                            MemberCount = 532,
                            AvgGroundWaterUse = 6250,
                            GroundWaterCount = 1,
                            AvgSurfaceWaterUse = 600
                        }
                    }
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