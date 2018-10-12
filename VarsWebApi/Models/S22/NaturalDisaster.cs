using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    // TODO: Fill more

    public class NaturalDisaster
    {
        public bool Tsunami { get; set; }
        public bool Earthquake { get; set; }
        public bool FireSmoke { get; set; }
        public bool Cold { get; set; }
        public bool Infection { get; set; }
        public bool Insects { get; set; }
        public bool Animals { get; set; }
    }
}
