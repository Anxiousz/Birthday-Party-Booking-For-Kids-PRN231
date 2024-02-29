﻿using BusinessObjects.Request;
using BussinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IPackageService
    {
        public int CountPackage();
        public List<Package> GetAllPackages();
        public Package GetPackageById(int id);
        public RequestPackageCreateDTO CreatePackage(RequestPackageCreateDTO request);
        public bool deletePackage(int id);
        public Package GetPackageByID(int id);
        public RequestPackageUpdateDTO UpdatePackage(RequestPackageUpdateDTO request);
    }
}
