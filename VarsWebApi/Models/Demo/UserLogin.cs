using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VarsWebApi.Models.Demo;

namespace VarsWebApi.Models
{
    public class UserLogin
    {
        [BsonId]
        public string _idqr { get; set; }
        public string IdUser { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string _id { get; set; }
        public List<EAInfo> EAList { get; set; }

    }

    
}