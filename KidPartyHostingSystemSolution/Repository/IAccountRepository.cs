﻿using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAccountRepository
    {
        public List<RegisteredUser> GetRegisteredUserAccount();
    }
}
