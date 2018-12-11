﻿using System;
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
        public DemoController()
        {
            db = new MongoClient("mongodb://abcd1234:abcd1234@ds127624.mlab.com:27624/demowater");
            var test = db.GetDatabase("demowater");
            Collection = test.GetCollection<UserLogin>("login");
            CollectionWork = test.GetCollection<Work>("login");

        }

        [HttpGet]
        public IEnumerable<UserLogin> GetAllUser()
        {
            var data = Collection.Find(x => true).ToList();
            return data;
        }

        [HttpPost]
        public bool CreateIdQr([FromBody]UserLogin model)
        {
            model._idqr = Guid.NewGuid().ToString();
            Collection.InsertOne(model);
            return true;
        }

        [HttpGet("{qr}")]
        public IEnumerable<UserLogin> GetQR(string qr)
        {
            return Collection.Find(x => x._idqr == qr).ToList();
        }

        [HttpPost]
        public void SetPasswordUser([FromBody]UserLogin request)
        {
            var data = Collection.Find(x => x._idqr == request._idqr).FirstOrDefault();
            data.Password = request.Password;
            Collection.ReplaceOne(x => x._idqr == request._idqr, data);
        }

        [HttpGet("{userId}")]
        public IEnumerable<UserLogin> GetUser(string userId)
        {
            return Collection.Find(x => x.IdUser == userId).ToList();
        }

        [HttpPost]
        public bool CreateWork([FromBody]Work model)
        {
            model.IdEA = Guid.NewGuid().ToString();
            CollectionWork.InsertOne(model);
            return true;
        }

        [HttpGet]
        public IEnumerable<Work> GetAllWork()
        {
            var data = CollectionWork.Find(x => true).ToList();
            return data;
        }

        [HttpGet("{id}")]
        public IEnumerable<Work> GetWork(string id)
        {
            return CollectionWork.Find(x => x.IdEA == id).ToList();
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
        [HttpGet("{IdEA}")]
        public IEnumerable<Work> GetBuildingFS(string IdEA)
        {
            return CollectionWork.Find(x => x.IdEA == IdEA).ToList();
        }




    }
}