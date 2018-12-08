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
    public class DemoController : ControllerBase
    {
        [HttpPost]
        public void Post(HouseHoldSample sample)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public string GetQR(string qr)
        {
            // 
            return "ID";
        }

        /*[HttpGet]
        public bool GetLogin(string id, string password)
        {
            // login success or fail
            return true;
        }*/

        /*[HttpGet]
        public string GetDataUsername(string id)
        {
            return "data user";
        }*/

        /*[HttpPost]
        public void SetPassword([FromBody] string id, string password)
        {
            //replace password by ID
        }*/

        /*[HttpGet]
        public string LoadWork(string userid)
        {
            return "id ea";
        }*/

        /*[HttpGet]
        public string IEnumerable<GetAllEA>(string idEA)
        {
            return "something in every ea";
        }*/

        /*[HttpGet]
        public string GetBuildingEA(string idEA)
        {
            return "data ea";
        }*/

        /*[HttpGet]
        public string GetCommunityEA(string idEA)
        {
            return "data ea";
        }*/

        /*[HttpGet]
        public string GetFSEA(string idEA)
        {
            return "data ea";
        }

        [HttpPost]
        public void HomeBuilding([FromBody] string value)
        {
            ///
        }

        [HttpPost]
        public void HomeCommunity([FromBody] string value)
        {
        }

        [HttpGet]
        public string HomeGetCommunity()
        {
            return "data commu";
        }

        [HttpGet]
        public string HomeBuilding()
        {
            return "data building";
        }

        [HttpPost]
        public void BuildingInfo([FromBody] string value)
        {
        }

        //[HttpPost]
        //public void BuildingData([FromBody] string value)
        //{
        //}

        //[HttpPost]
        //public void UnitData([FromBody] string value)
        //{
        //}

        //[HttpPost]
        //public void SN21([FromBody] string value)
        //{
        //}

        //[HttpGet]
        //public ActionResult<IEnumerable<string>> SN21()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //[HttpPost]
        //public void SN22([FromBody] string value)
        //{
        //}*/


    }
}
