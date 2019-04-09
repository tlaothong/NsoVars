using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class PumpRateModel
    {
        public EnergySource EnergyFromPump { get; set; }
        public string PumpType { get; set; }
        public string Power { get; set; }
        public string SuctionPipeSize { get; set; }
        public string PipelineSize { get; set; }
        public int PumpRate { get; set; }
    }
}
