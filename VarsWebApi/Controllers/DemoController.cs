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
        IMongoCollection<BuildingSample> CollectionHomeBuilding;
        IMongoCollection<CommunitySample> CollectionHomeCommunity;

        public DemoController()
        {
            db = new MongoClient("mongodb://abcd1234:abcd1234@ds127624.mlab.com:27624/demowater");
            var test = db.GetDatabase("demowater");
            Collection = test.GetCollection<UserLogin>("login");
            CollectionWork = test.GetCollection<Work>("work");
            CollectionHomeBuilding = test.GetCollection<BuildingSample>("homebuilding");
            CollectionHomeCommunity = test.GetCollection<CommunitySample>("homecommunity");

        }

        [HttpGet]
        public IEnumerable<UserLogin> GetAllUser()
        {
            return Collection.Find(x => true).ToList();
        }

        [HttpPost]
        public bool CreateIdQr([FromBody]UserLogin model)
        {
            model._idqr = Guid.NewGuid().ToString();
            Collection.InsertOne(model);
            return true;
        }

        [HttpGet("{qr}")]
        public UserLogin GetUserByQRCode(string qr)
        {
            return Collection.Find(x => x._idqr == qr).FirstOrDefault();
        }

        [HttpPost]
        public void SetPasswordUser([FromBody]UserLogin request)
        {
            var data = Collection.Find(x => x._idqr == request._idqr).FirstOrDefault();
            data.Password = request.Password;
            Collection.ReplaceOne(x => x._idqr == request._idqr, data);
        }

        [HttpGet("{userId}")]
        public UserLogin GetUserByID(string IdUser)
        {
            return Collection.Find(x => x.IdUser == IdUser).FirstOrDefault();
        }

        [HttpPost]
        public bool CreateWork([FromBody]Work model)
        {
            CollectionWork.InsertOne(model);
            return true;
        }

        [HttpGet("{id}")]
        public IEnumerable<Work> GetAllWorkByIDUser(string id)
        {
            return CollectionWork.Find(x => x.IdUser == id).ToList();
        }

        [HttpGet("{id}")]
        public int GetCountWorkByIDUser(string id)
        {
            return CollectionWork.Find(x => x.IdUser == id).ToList().Count();
        }

        [HttpGet("{id}")]
        public Work GetWorkByIdEA(string id)
        {
            return CollectionWork.Find(x => x.IdEA == id).FirstOrDefault();
        }

        [HttpPost]
        public void CreateBuilding([FromBody]BuildingSample data)
        {
            data._id = Guid.NewGuid().ToString();
            CollectionHomeBuilding.InsertOne(data);
        }

        [HttpGet]
        public IEnumerable<BuildingSample> GetAllBuildingByIdUser()
        {
            return CollectionHomeBuilding.Find(x =>true).ToList();
        }

        [HttpGet]
        public int GetCountBuildingByIdUser()
        {
            return CollectionHomeBuilding.Find(x => true).ToList().Count();
        }
        //[HttpGet("{IdEA}")]
        //public IEnumerable<HomeBuildingEA> GetBuildingByIdEA(string IdEA)
        //{
        //    return CollectionHomeBuilding.Find(x => x.IdEA == IdEA).ToList();
        //}

        //[HttpGet("{IdEA}")]
        //public IEnumerable<HomeCommunity> GetCommunityByIdEA(string IdEA)
        //{
        //    return CollectionHomeCommunity.Find(x => x.IdEA == IdEA).ToList();
        //}

        //[HttpGet("{IdEA}")]
        //public IEnumerable<Work> GetFSByIdEA(string IdEA)
        //{
        //    return CollectionWork.Find(x => x.IdEA == IdEA).ToList();
        //}




    }
}
