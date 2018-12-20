using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class HomeBuildingEA
    {
        [BsonId]
        public string IdEA { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Survey { get; set; }
        public int Amount { get; set; }
        public string Status { get; set; }
    }
}
