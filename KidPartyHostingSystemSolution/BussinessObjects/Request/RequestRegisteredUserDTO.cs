﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Request
{
    public class RequestRegisteredUserDTO
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
    }
}
