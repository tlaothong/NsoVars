using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VarsWebApi.Models;
using MongoDB.Driver;

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

        [HttpGet]
        public int GetCountBuilding()
        {
            var result = CollectionHomeBuilding.Find(x => true).ToList().Count();
            if (result == null)
            {
                return 0;
            }
            return result;
        }

        [HttpGet("{IdEA}")]
        public IEnumerable<BuildingSample> GetBuildingByIdEA(string IdEA)
        {
            return CollectionHomeBuilding.Find(it => it.EA == IdEA).ToList();
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
        public void CreateCommunity([FromBody]CommunitySample data)
        {
            data._id = Guid.NewGuid().ToString();
            CollectionHomeCommunity.InsertOne(data);
        }

        [HttpPost]
        public bool CreateWork([FromBody]Work model)
        {
            CollectionWork.InsertOne(model);
            return true;
        }

        [HttpDelete("{id}")]
        public void RemoveBuilding(string id)
        {
            CollectionHomeBuilding.DeleteOne(x => x._id == id);
        }

        [HttpPost]
        public void CreateUnit([FromBody]HouseHoldSample data)
        {
            var unit = CollectionHouseHold.Find(it => it._id == data._id).FirstOrDefault();
            if (unit == null)
            {
                data._id = Guid.NewGuid().ToString();
                CollectionHouseHold.InsertOne(data);

            }
            else
            {
                CollectionHouseHold.ReplaceOne((it) => it._id == data._id, data);
            }


        }


    }
}
