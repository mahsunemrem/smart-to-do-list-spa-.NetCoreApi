﻿using SmartToDoListAPI.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartToDoListAPI.Entities.Dtos
{
    public class UserForLoginDto : Dto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
