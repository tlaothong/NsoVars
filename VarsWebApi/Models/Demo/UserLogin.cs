﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VarsWebApi.Models
{
    public class UserLogin
    {
        public string IdQr { get; set; }
        public string IdUser { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}