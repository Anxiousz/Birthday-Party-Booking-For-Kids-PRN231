﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
    public class PackageRepository : IPackageRepository
    {

        private PackageDAO packageDAO;
        public PackageRepository()
        {
            packageDAO = new PackageDAO();
        }
    }
}