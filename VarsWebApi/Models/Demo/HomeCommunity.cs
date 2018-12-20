using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class HomeCommunity
    {
        [BsonId]
        public string IdEA { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string status { get; set; }
    }
}
