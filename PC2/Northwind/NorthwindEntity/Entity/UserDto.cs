﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntity.Entity
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}