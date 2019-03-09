using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VarsWebApi.Models;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace VarsWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        MongoClient db;
        IMongoCollection<UserLogin> Collection;
        IMongoCollection<Work> CollectionWork;
        IMongoCollection<Department> CollectionDepartment;
        IMongoCollection<BuildingSample> CollectionHomeBuilding;
        IMongoCollection<CommunitySample> CollectionHomeCommunity;
        IMongoCollection<HouseHoldSample> CollectionHouseHold;

        public DemoController()
        {
            db = new MongoClient("mongodb://abcd1234:abcd1234@ds127624.mlab.com:27624/demowater");
            var test = db.GetDatabase("demowater");
            Collection = test.GetCollection<UserLogin>("login");
            CollectionWork = test.GetCollection<Work>("work");
            CollectionDepartment = test.GetCollection<Department>("department");
            CollectionHomeBuilding = test.GetCollection<BuildingSample>("homebuilding");
            CollectionHomeCommunity = test.GetCollection<CommunitySample>("homecommunity");
            CollectionDepartment = test.GetCollection<Department>("department");
            CollectionHouseHold = test.GetCollection<HouseHoldSample>("household");
        }

        [HttpGet]
        public IEnumerable<UserLogin> GetAllUser()
        {
            return Collection.Find(x => true).ToList();
        }

        [HttpPost]
        public bool GetLogin(UserLogin data)
        {
            var user = Collection.Find(it => (it.IdUser == data.IdUser) && (it.Password == data.Password)).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;

        }

        [HttpGet("{qr}")]
        public UserLogin GetUserByQRCode(string qr)
        {
            return Collection.Find(x => x._idqr == qr).FirstOrDefault();
        }

        [HttpGet("{userId}")]
        public UserLogin GetUserByID(string userId)
        {
            return Collection.Find(x => x.IdUser == userId).FirstOrDefault();
        }

        [HttpGet("{id}")]
        public IEnumerable<Department> GetAllWorkByUserID(string id)
        {
            var user = Collection.Find(it => it.IdUser == id).FirstOrDefault();
            var result = new List<Department> { };
            foreach (var item in user.IdEA)
            {
                var get = CollectionDepartment.Find(it => it._id == item).FirstOrDefault();
                result.Add(get);
            }
            return result;
        }

        [HttpGet("{id}")]
        public Work GetWorkByWorkUserIdEA(string id)
        {
            return CollectionWork.Find(x => x.IdEA == id).FirstOrDefault();
        }

        [HttpGet("{IdEA}")]
        public IEnumerable<Work> GetBuildingEA(string IdEA)
        {
            return CollectionWork.Find(x => x.IdEA == IdEA).ToList();
        }

        [HttpGet("{IdEA}")]
        public IEnumerable<Work> GetBuildingCommunity(string IdEA)
        {
            return CollectionWork.Find(x => x.IdEA == IdEA).ToList();
        }

        [HttpGet]
        public IEnumerable<Department> GetDepartment()
        {
            return CollectionDepartment.Find(x => true).ToList();
        }

        [HttpGet("{userId}")]
        public int GetCountWorkByIDUser(string userId)
        {
            var getUser = Collection.Find(it => it.IdUser == userId).FirstOrDefault();
            return getUser.IdEA.Count() > 0 ? getUser.IdEA.Count() : 0;
        }

        [HttpGet]
        public IEnumerable<CommunitySample> GetAllCommunity()
        {
            return CollectionHomeCommunity.Find(x => true).ToList();
        }

        [HttpGet]
        public int GetCountCommunity()
        {
            return CollectionHomeCommunity.Find(x => true).ToList().Count();
        }

        [HttpGet]
        public IEnumerable<BuildingSample> GetAllBuilding()
        {
            return CollectionHomeBuilding.Find(x => true).ToList();
        }

        [HttpGet("{IdEA}")]
        public IEnumerable<BuildingSample> GetBuildingByIdEA(string IdEA)
        {
            return CollectionHomeBuilding.Find(it => it.EA == IdEA).ToList();
        }


        [HttpGet("{Id_BD}")]
        public List<Unit> GetUnitByIdBuilding(string Id_BD)
        {
            var unitNew = CollectionHouseHold.Find(it => it.BuildingId == Id_BD).ToList();
            var result = new List<Unit>();
            foreach (var item in unitNew)
            {
                result.Add(new Unit
                {
                    _id = item._id,
                    EA = item.EA,
                    BuildingId = item.BuildingId,
                    SubUnit = item.SubUnit,
                    IsHouseHold = item.IsHouseHold,
                    IsAgriculture = item.IsAgriculture,
                    IsFactorial = item.IsFactorial,
                    IsCommercial = item.IsCommercial,
                    Comments = item.Comments,
                    Status = item.Status,
                });
            }
            return result;
        }

        [HttpGet("{id_unit}")]
        public HouseHoldSample GetdataOfUnit(string id_unit)
        {
            return CollectionHouseHold.Find(it => it._id == id_unit).FirstOrDefault();
        }

        [HttpGet("{id_BD}")]
        public BuildingSample GetBuilding(string id_BD)
        {
            return CollectionHomeBuilding.Find(it => it._id == id_BD).FirstOrDefault();
        }

        [HttpGet("{id_ea}")]
        public IEnumerable<CommunitySample> GetAllCommunityByIdEA(string id_ea)
        {
            return CollectionHomeCommunity.Find(it => it.EA == id_ea).ToList();
        }

        [HttpGet("{id_com}")]
        public CommunitySample GetCommunity(string id_com)
        {
            return CollectionHomeCommunity.Find(it => it._id == id_com).FirstOrDefault();
        }

        [HttpDelete("{id}")]
        public void RemoveBuilding(string id)
        {
            CollectionHomeBuilding.DeleteOne(x => x._id == id);
        }

        [HttpPost]
        public bool CreateIdQr([FromBody]UserLogin model)
        {
            model._idqr = Guid.NewGuid().ToString();
            Collection.InsertOne(model);
            return true;
        }

        [HttpPost]
        public void SetPasswordUser([FromBody]UserLogin request)
        {
            var data = Collection.Find(x => x._idqr == request._idqr).FirstOrDefault();
            data.Password = request.Password;
            Collection.ReplaceOne(x => x._idqr == request._idqr, data);
        }

        [HttpPost]
        public BuildingSample CreateBuilding([FromBody]BuildingSample data)
        {
            if (data._id == null)
            {
                data._id = Guid.NewGuid().ToString();
                CollectionHomeBuilding.InsertOne(data);
            }
            else
            {
                CollectionHomeBuilding.ReplaceOne((it) => it._id == data._id, data);
            }
            return data;
        }

        [HttpPost]
        public HouseHoldSample CreateUnit([FromBody]HouseHoldSample data)
        {
            var find = CollectionHouseHold.Find(it => it._id == data._id).FirstOrDefault();
            var building = GetBuilding(data.BuildingId);
            if (find == null)
            {
                data.Residence = new Residential()
                {
                    WaterSources = new WaterSources()
                };
                data.Agriculture = new Agriculture()
                {
                    RicePlant = new PlantingInfo<RicePlantingField>()
                    {
                        Fields = new List<RicePlantingField> { }
                    },
                    AgronomyPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Fields = new List<GrowingFieldWithNames>(),
                    },
                    RubberTree = new PlantingInfo<GrowingField>()
                    {
                        Fields = new List<GrowingField>(),
                    },
                    PerennialPlant = new PlantingInfo<GrowingFieldWithNames>()
                    {
                        Fields = new List<GrowingFieldWithNames>()
                    },
                    HerbsPlant = new PlantingInfo<MixablePlantingField>()
                    {
                        Fields = new List<MixablePlantingField>()
                    },
                    FlowerCrop = new PlantingInfo<MixablePlantingField>()
                    {
                        Fields = new List<MixablePlantingField>()
                    },
                    MushroomPlant = new PlantingInfo<MushroomField>()
                    {
                        Fields = new List<MushroomField>()
                    },
                    AnimalFarm = new Farming()
                    {
                        Cow = new HasAndCount(),
                        Buffalo = new HasAndCount(),
                        Pig = new HasAndCount(),
                        Goat = new HasAndCount(),
                        Sheep = new HasAndCount(),
                        Chicken = new HasAndCount(),
                        Goose = new HasAndCount(),
                        SilkWool = new HasAndCount(),
                        Duck = new HasAndCount(),
                        Other = new HasAndCount(),
                        WaterSources = new WaterSources()
                    },
                    AquaticAnimals = new AquaticAnimals()
                    {
                        Fish = new FishFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        Shrimp = new FishFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        Frog = new FrogFarming()
                        {
                            WaterSources = new WaterSources()
                        },
                        Crocodile = new CrocodileFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        SnappingTurtle = new CrocodileFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        Crab = new FishFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        ShellFish = new FishFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        Reddish = new FishFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        },
                        Turtle = new CrocodileFarming()
                        {
                            Fields = new List<FieldSize>(),
                            WaterSources = new WaterSources()
                        }
                    }
                };
                data.Factory = new Factorial()
                {
                    WaterSources = new WaterSources(),
                };
                data.Commerce = new Commercial()
                {
                    QuestionForAcademy = new Academy()
                    {
                        PreSchool = new HasAndCount(),
                        Kindergarten = new HasAndCount(),
                        PrimarySchool = new HasAndCount(),
                        HighSchool = new HasAndCount(),
                        Vocational = new HasAndCount(),
                        HigherEducation = new HasAndCount(),
                    },
                    HotelsAndResorts = new HotelsAndResorts(),
                    Hospital = new Hospital(),
                    Building = new Building(),
                    Religious = new Religious(),
                    OtherBuilding = new OtherBuilding(),
                    WaterSources = new WaterSources(),
                };
                data.WaterUsage = new WaterUsage()
                {
                    Plumbing = new Plumbing()
                    {
                        MWA = new PlumbingInfo()
                        {
                            QualityProblem = new WaterProblem()
                            {
                                Problem = new Problem(),
                            },
                            PlumbingUsage = new PlumbingUsage(),
                        },
                        PWA = new PlumbingInfo()
                        {
                            QualityProblem = new WaterProblem()
                            {
                                Problem = new Problem(),
                            },
                            PlumbingUsage = new PlumbingUsage(),
                        },
                        Other = new PlumbingInfo()
                        {
                            QualityProblem = new WaterProblem()
                            {
                                Problem = new Problem(),
                            },
                            PlumbingUsage = new PlumbingUsage(),
                        },
                        WaterActivityMWA = new WaterActivity(),
                        WaterActivityPWA = new WaterActivity(),
                        WaterActivityOther = new WaterActivity(),
                    },
                    GroundWater = new GroundWater()
                    {
                        PrivateGroundWater = new PrivateGroundWater()
                        {
                            WaterResources = new List<GroundWaterWell>(),
                        },
                        PublicGroundWater = new PublicGroundWater()
                        {
                            WaterResources = new List<WaterConsumptionUsingPump>(),
                        },
                    },
                    River = new River()
                    {
                        Pumps = new List<Pump>(),
                        WaterActivities = new WaterActivity(),
                        QualityProblem = new WaterProblem()
                        {
                            Problem = new Problem()
                        },
                    },
                    Pool = new Pool()
                    {
                        PoolSizes = new List<FieldSize>(),
                        WaterResources = new List<WaterConsumptionUsingPump>()
                    },
                    Irrigation = new Irrigation()
                    {
                        Pumps = new List<Pump>(),
                        WaterActivities = new WaterActivity(),
                        QualityProblem = new WaterProblem()
                        {
                            Problem = new Problem()
                        },
                    },
                    Rain = new Rain()
                    {
                        RainContainers = new List<RainContainer>(){
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                            new RainContainer(),
                        },
                        WaterActivities = new WaterActivity() { }
                    },
                    Buying = new Buying()
                    {
                        Package = new List<Package>(){
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                            new Package(),
                        }
                    }
                };
                data.Disaster = new Disasterous()
                {
                    YearsDisasterous = new List<YearsDisasterous>(){
                        new YearsDisasterous(),
                        new YearsDisasterous(),
                        new YearsDisasterous(),
                        new YearsDisasterous(),
                        new YearsDisasterous(),
                    }
                };
                data.Closing = new ClosingInfo();
                data.Population = new Population()
                {
                    Persons = new List<Person>()
                };
                data.RecCtrl = new RecordControl()
                {
                    Logs = new List<RecordControlLog>()
                };
                CollectionHouseHold.InsertOne(data);

                if (data.Status == "complete")
                {
                    building.UnitCountComplete++;
                    if (building.UnitCountComplete == building.UnitCount)
                    {
                        building.Status = "done-all";
                    }
                    CollectionHomeBuilding.ReplaceOne(it => it._id == building._id, building);
                }
            }
            else
            {
                if (find.Status != data.Status && (find.Status == "complete" || data.Status == "complete"))
                {
                    building.UnitCountComplete += (data.Status == "complete") ? 1 : -1;
                    if (building.UnitCountComplete == building.UnitCount)
                    {
                        building.Status = "done-all";
                    }
                    CollectionHomeBuilding.ReplaceOne(it => it._id == building._id, building);
                }

                CollectionHouseHold.ReplaceOne((it) => it._id == find._id, data);
            }
            return CollectionHouseHold.Find(it => it._id == data._id).FirstOrDefault(); ;
        }

        [HttpPost]
        public bool CreateWork([FromBody]Work model)
        {
            CollectionWork.InsertOne(model);
            return true;
        }

        [HttpPost]
        public CommunitySample CreateCommunity([FromBody]CommunitySample data)
        {
            if (data._id == null)
            {
                data._id = Guid.NewGuid().ToString();
                CollectionHomeCommunity.InsertOne(data);
            }
            else
            {
                CollectionHomeCommunity.ReplaceOne(it => it._id == data._id, data);
            }
            return data;
        }

        [HttpGet]
        public double? WaterUsageRate(string UnitId, string BuildingId, string CommunityId)
        {
            var Unit = GetdataOfUnit(UnitId);
            var Building = GetBuilding("d9147110-228c-443d-aefd-dcb3f09d58cb");//10
            var Community = GetCommunity(CommunityId);

            // // WaterUsage.Plumbing.MWA - ทราบปริมาณน้ำ 
            // if (Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
            // {
            //     var CubicMeterPerMonth = Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.CubicMeterPerMonth * (Unit.WaterUsage.Plumbing.WaterActivityMWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }
            //// WaterUsage.Plumbing.PWA - ทราบปริมาณน้ำ
            // else if (Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
            // {
            //     var CubicMeterPerMonth = Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.CubicMeterPerMonth * (Unit.WaterUsage.Plumbing.WaterActivityPWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }
            //// WaterUsage.Plumbing.Other - ทราบปริมาณน้ำ
            // else if (Unit.WaterUsage.Plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.CubicMeterPerMonth)
            // {
            //     var CubicMeterPerMonth = Unit.WaterUsage.Plumbing.Other.PlumbingUsage.CubicMeterPerMonth * (Unit.WaterUsage.Plumbing.WaterActivityOther.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }

            //// WaterUsage.Plumbing.MWA - ไม่ทราบปริมาณน้ำ TYPE:A
            // else if (((Building.BuildingType == BuildingType.SingleHouse)
            //     || (Building.BuildingType == BuildingType.TownHouse)
            //     || (Building.BuildingType == BuildingType.ShopHouse)
            //     || (Building.BuildingType == BuildingType.Apartment)
            //     || (Building.BuildingType == BuildingType.Religious)
            //     || (Building.BuildingType == BuildingType.GreenHouse))
            //     && (Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill))
            // {
            //     var WaterBill = Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.WaterBill / 10.5;
            //     var CubicMeterPerMonth = WaterBill * (Unit.WaterUsage.Plumbing.WaterActivityMWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }

            //// WaterUsage.Plumbing.PWA - ไม่ทราบปริมาณน้ำ TYPE:A
            // else if (((Building.BuildingType == BuildingType.SingleHouse)
            //    || (Building.BuildingType == BuildingType.TownHouse)
            //    || (Building.BuildingType == BuildingType.ShopHouse)
            //    || (Building.BuildingType == BuildingType.Apartment)
            //    || (Building.BuildingType == BuildingType.Religious)
            //    || (Building.BuildingType == BuildingType.GreenHouse))
            //    && (Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill))
            // {
            //     var WaterBill = Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.WaterBill / 16.6;
            //     var CubicMeterPerMonth = WaterBill * (Unit.WaterUsage.Plumbing.WaterActivityPWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }

            //// WaterUsage.Plumbing.MWA - ไม่ทราบปริมาณน้ำ TYPE:B
            // else if (((Building.BuildingType == BuildingType.Office)
            //  || (Building.BuildingType == BuildingType.Hotel)
            //  || (Building.BuildingType == BuildingType.PublicHospital)
            //  || (Building.BuildingType == BuildingType.PrivateHospital)
            //  || (Building.BuildingType == BuildingType.GovernmentOffice)
            //  || (Building.BuildingType == BuildingType.PublicSchool)
            //  || (Building.BuildingType == BuildingType.PrivateSchool)
            //  || (Building.BuildingType == BuildingType.Factory)
            //  || (Building.BuildingType == BuildingType.UnderConstruction)
            //  || (Building.BuildingType == BuildingType.Other))
            //  && (Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill))
            // {
            //     var WaterBill = Unit.WaterUsage.Plumbing.MWA.PlumbingUsage.WaterBill / 13;
            //     var CubicMeterPerMonth = WaterBill * (Unit.WaterUsage.Plumbing.WaterActivityMWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }

            //// WaterUsage.Plumbing.PWA - ไม่ทราบปริมาณน้ำ TYPE:B
            // else if (((Building.BuildingType == BuildingType.Office)
            //   || (Building.BuildingType == BuildingType.Hotel)
            //   || (Building.BuildingType == BuildingType.PublicHospital)
            //   || (Building.BuildingType == BuildingType.PrivateHospital)
            //   || (Building.BuildingType == BuildingType.GovernmentOffice)
            //   || (Building.BuildingType == BuildingType.PublicSchool)
            //   || (Building.BuildingType == BuildingType.PrivateSchool)
            //   || (Building.BuildingType == BuildingType.Factory)
            //   || (Building.BuildingType == BuildingType.UnderConstruction)
            //   || (Building.BuildingType == BuildingType.Other))
            //   && (Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill))
            // {
            //     var WaterBill = Unit.WaterUsage.Plumbing.PWA.PlumbingUsage.WaterBill / 26;
            //     var CubicMeterPerMonth = WaterBill * (Unit.WaterUsage.Plumbing.WaterActivityPWA.Drink / 100) * 12;
            //     return CubicMeterPerMonth;
            // }

            //// WaterUsage.Plumbing.Other - ไม่ทราบปริมาณน้ำ
            // else if (Unit.WaterUsage.Plumbing.Other.PlumbingUsage.WaterQuantity == WaterQuantity.WaterBill)
            // {
            //     var ServicesCount = Community.Management.WaterServices;
            //     double Meter = 0;
            //     double Price = 0;
            //     for (int i = 0; i < Community.Management.WaterServiceCount; i++)
            //     {
            //         foreach (var item in ServicesCount)
            //         {
            //             Meter += item.MeterRentalFee ?? 0;
            //             Price += item.PlumbingPrice ?? 0;
            //         }
            //     }
            //     var avgMeter = Meter / Community.Management.WaterServiceCount;
            //     var avgPlumbing = Price / Community.Management.WaterServiceCount;

            //     var WaterBill = (Unit.WaterUsage.Plumbing.Other.PlumbingUsage.WaterBill - avgMeter) / avgPlumbing;
            //     var CubicMeterPerMonth = WaterBill * (Unit.WaterUsage.Plumbing.WaterActivityOther.Drink / 100) * 12;

            //     return CubicMeterPerMonth;

            // }

            //WaterUsage.Rain - ทราบปริมาณน้ำ
            // else if (WaterUsage.Rain)
            var index0 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[0].Size)
            {
                case "100 - 1,000": index0 = (550 * Unit.WaterUsage.Rain.RainContainers[0].Count); return index0; break;
                case "1,000 - 5,000": index0 = (3000 * Unit.WaterUsage.Rain.RainContainers[0].Count); return index0; break;
                case "5,000 - 10,000": index0 = (7500 * Unit.WaterUsage.Rain.RainContainers[0].Count); return index0; break;
                case "10,000 - 15,000": index0 = (12500 * Unit.WaterUsage.Rain.RainContainers[0].Count); return index0; break;
            }

            var index1 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[1].Size)
            {
                case "100 - 1,000": index1 = (550 * Unit.WaterUsage.Rain.RainContainers[1].Count); return index1; break;
                case "1,000 - 5,000": index1 = (3000 * Unit.WaterUsage.Rain.RainContainers[1].Count); return index1; break;
                case "5,000 - 10,000": index1 = (7500 * Unit.WaterUsage.Rain.RainContainers[1].Count); return index1; break;
                case "10,000 - 15,000": index1 = (12500 * Unit.WaterUsage.Rain.RainContainers[1].Count); return index1; break;
            }

            var index2 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[2].Size)
            {
                case "500 - 1,000": index2 = (750 * Unit.WaterUsage.Rain.RainContainers[2].Count); return index2; break;
                case "1,000 - 5,000": index2 = (3000 * Unit.WaterUsage.Rain.RainContainers[2].Count); return index2; break;
                case "5,000 - 10,000": index2 = (7500 * Unit.WaterUsage.Rain.RainContainers[2].Count); return index2; break;
                case "10,000 - 15,000": index2 = (12500 * Unit.WaterUsage.Rain.RainContainers[2].Count); return index2; break;
                case "15,000 - 20,000": index2 = (17500 * Unit.WaterUsage.Rain.RainContainers[2].Count); return index2; break;
            }

            var index3 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[3].Size)
            {
                case "5,000 - 10,000": index3 = (7500 * Unit.WaterUsage.Rain.RainContainers[3].Count); return index3; break;
                case "10,000 - 20,000": index3 = (15000 * Unit.WaterUsage.Rain.RainContainers[3].Count); return index3; break;
                case "20,000 - 30,000": index3 = (25000 * Unit.WaterUsage.Rain.RainContainers[3].Count); return index3; break;
                case "30,000 - 40,000": index3 = (35000 * Unit.WaterUsage.Rain.RainContainers[3].Count); return index3; break;
                case "40,000 - 50,000": index3 = (45000 * Unit.WaterUsage.Rain.RainContainers[3].Count); return index3; break;
            }

            var index4 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[4].Size)
            {
                case "50 - 300": index4 = (175 * Unit.WaterUsage.Rain.RainContainers[4].Count); return index4; break;
                case "300 - 1,000": index4 = (650 * Unit.WaterUsage.Rain.RainContainers[4].Count); return index4; break;
                case "1,000 - 2,000": index4 = (1500 * Unit.WaterUsage.Rain.RainContainers[4].Count); return index4; break;
            }

            var index5 = new double?();
            switch (Unit.WaterUsage.Rain.RainContainers[5].Size)
            {
                case "50 - 200": index5 = (125 * Unit.WaterUsage.Rain.RainContainers[5].Count); return index5; break;
                case "200 - 300": index5 = (250 * Unit.WaterUsage.Rain.RainContainers[5].Count); return index5; break;
            }

            var index6 = new double?();
            if (Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ สแตนเลส" || Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ โพลิเมอร์/พลาสติก")
            {
                switch (Unit.WaterUsage.Rain.RainContainers[6].Size)
                {
                    case "100 - 1,000": index6 = (550 * Unit.WaterUsage.Rain.RainContainers[6].Count); return index6; break;
                    case "1,000 - 5,000": index6 = (3000 * Unit.WaterUsage.Rain.RainContainers[6].Count); return index6; break;
                    case "5,000 - 10,000": index6 = (7500 * Unit.WaterUsage.Rain.RainContainers[6].Count); return index6; break;
                    case "10,000 - 15,000": index6 = (12500 * Unit.WaterUsage.Rain.RainContainers[6].Count); return index6; break;
                } 
            }


            // double? rainType = ((550 * Unit.WaterUsage.Rain.RainContainers[0].Count) +
            //                         (3000 * Unit.WaterUsage.Rain.RainContainers[0].Count) +
            //                         (7500 * Unit.WaterUsage.Rain.RainContainers[0].Count) +
            //                         (12500 * Unit.WaterUsage.Rain.RainContainers[0].Count)) +

            //                         ((550 * Unit.WaterUsage.Rain.RainContainers[1].Count) +
            //                         (3000 * Unit.WaterUsage.Rain.RainContainers[1].Count) +
            //                         (7500 * Unit.WaterUsage.Rain.RainContainers[1].Count) +
            //                         (12500 * Unit.WaterUsage.Rain.RainContainers[1].Count)) +

            //                         ((750 * Unit.WaterUsage.Rain.RainContainers[2].Count) +
            //                         (3000 * Unit.WaterUsage.Rain.RainContainers[2].Count) +
            //                         (7500 * Unit.WaterUsage.Rain.RainContainers[2].Count) +
            //                         (12500 * Unit.WaterUsage.Rain.RainContainers[2].Count) +
            //                         (17500 * Unit.WaterUsage.Rain.RainContainers[2].Count)) +

            //                         ((7500 * Unit.WaterUsage.Rain.RainContainers[3].Count) +
            //                         (15000 * Unit.WaterUsage.Rain.RainContainers[3].Count) +
            //                         (25000 * Unit.WaterUsage.Rain.RainContainers[3].Count) +
            //                         (35000 * Unit.WaterUsage.Rain.RainContainers[3].Count) +
            //                         (45000 * Unit.WaterUsage.Rain.RainContainers[3].Count)) +

            //                         ((175 * Unit.WaterUsage.Rain.RainContainers[4].Count) +
            //                         (650 * Unit.WaterUsage.Rain.RainContainers[4].Count) +
            //                         (1500 * Unit.WaterUsage.Rain.RainContainers[4].Count)) +

            //                         ((125 * Unit.WaterUsage.Rain.RainContainers[5].Count) +
            //                         (250 * Unit.WaterUsage.Rain.RainContainers[5].Count));
            double? other1 = 0;
            if (Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ สแตนเลส" || Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ โพลิเมอร์/พลาสติก")
            {
                other1 = (550 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                (3000 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                (7500 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                (12500 * Unit.WaterUsage.Rain.RainContainers[6].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ ไฟเบอร์กลาส")
            {
                other1 = (750 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                 (3000 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                 (7500 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                 (12500 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                                 (17500 * Unit.WaterUsage.Rain.RainContainers[6].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[6].Category == "แท้งค์น้ำ ปูน/ซีเมนต์")
            {
                other1 = (7500 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                             (15000 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                             (25000 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                             (35000 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                             (45000 * Unit.WaterUsage.Rain.RainContainers[6].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[6].Category == "โอ่ง ปูน/ดินเผา")
            {
                other1 = (175 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                           (650 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                           (1500 * Unit.WaterUsage.Rain.RainContainers[6].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[6].Category == "ถัง โพลิเมอร์/พลาสติก")
            {
                other1 = (125 * Unit.WaterUsage.Rain.RainContainers[6].Count) +
                         (250 * Unit.WaterUsage.Rain.RainContainers[6].Count);
            }

            double? other2 = 0;
            if (Unit.WaterUsage.Rain.RainContainers[7].Category == "แท้งค์น้ำ สแตนเลส" || Unit.WaterUsage.Rain.RainContainers[7].Category == "แท้งค์น้ำ โพลิเมอร์/พลาสติก")
            {
                other2 = (550 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                (3000 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                (7500 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                (12500 * Unit.WaterUsage.Rain.RainContainers[7].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[7].Category == "แท้งค์น้ำ ไฟเบอร์กลาส")
            {
                other2 = (750 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                 (3000 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                 (7500 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                 (12500 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                                 (17500 * Unit.WaterUsage.Rain.RainContainers[7].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[7].Category == "แท้งค์น้ำ ปูน/ซีเมนต์")
            {
                other2 = (7500 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                             (15000 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                             (25000 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                             (35000 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                             (45000 * Unit.WaterUsage.Rain.RainContainers[7].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[7].Category == "โอ่ง ปูน/ดินเผา")
            {
                other2 = (175 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                           (650 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                           (1500 * Unit.WaterUsage.Rain.RainContainers[7].Count);
            }
            else if (Unit.WaterUsage.Rain.RainContainers[7].Category == "ถัง โพลิเมอร์/พลาสติก")
            {
                other2 = (125 * Unit.WaterUsage.Rain.RainContainers[7].Count) +
                         (250 * Unit.WaterUsage.Rain.RainContainers[7].Count);
            }


            // double? quantityOfRain = rainType + other1 + other2;
            // double? CubicMeterPerMonth = (quantityOfRain * (Unit.WaterUsage.Rain.WaterActivities.Drink / 100)) / 1000;
            // return CubicMeterPerMonth;
            return 0;
            // }

            ////WaterUsage.Buying - ทราบปริมาณน้ำ
            //// else if (WaterUsage.Buying)
            // double? quantityOfBuying = (Unit.WaterUsage.Buying.Package[0].Size / 1000 * Unit.WaterUsage.Buying.Package[0].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[1].Size / 1000 * Unit.WaterUsage.Buying.Package[1].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[2].Size / 1000 * Unit.WaterUsage.Buying.Package[2].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[3].Size / 1000 * Unit.WaterUsage.Buying.Package[3].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[4].Size / 1000 * Unit.WaterUsage.Buying.Package[4].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[5].Size * Unit.WaterUsage.Buying.Package[5].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[6].Size * Unit.WaterUsage.Buying.Package[6].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[7].Size * Unit.WaterUsage.Buying.Package[7].Drink) +
            //                             (Unit.WaterUsage.Buying.Package[8].Size * Unit.WaterUsage.Buying.Package[8].Drink);

            // var CubicMeterPerMonth = quantityOfBuying / 1000;
            // return CubicMeterPerMonth;
            //// }
        }
    }
}

