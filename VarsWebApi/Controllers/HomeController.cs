using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VarsWebApi.Models;

namespace VarsWebApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("swagger");
        }
    }
}