﻿using BussinessObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ITransactionBookingRepository
    {
        Task<ResponseTransactionDTO> GetTransactionById(int id);
    }
}
