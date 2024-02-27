using AutoMapper;
using BusinessObjects.Request;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace DAO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RequestPartyHostDTO, PartyHost>();
            CreateMap<RequestRegisteredUserDTO, RegisteredUser>();
        }
    }
}
