﻿using BusinessObjects.Request;
using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IConfigRepository
    {
        public RequestConfigDTO CreateConfig(RequestConfigDTO request);
        public Config checkConfigByID(int id);
        public RequestUpdateConfigDTO UpdateConfig(RequestUpdateConfigDTO request);
        public List<Config> GetConfig();
    }
}
