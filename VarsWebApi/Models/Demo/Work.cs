using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class Work
    {
        public string IdEA { get; set; }
        public string UserId { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string SubDistrict { get; set; }
        public string Administrative { get; set; }
        public string Municipalities { get; set; }
    }
}
