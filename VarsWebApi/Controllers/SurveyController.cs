using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VarsWebApi.Models;

namespace VarsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        public ActionResult<HouseHoldSample> Get()
        {
            throw new NotImplementedException();
        }

        public void Post(HouseHoldSample sample)
        {
            throw new NotImplementedException();
        }
    }
}