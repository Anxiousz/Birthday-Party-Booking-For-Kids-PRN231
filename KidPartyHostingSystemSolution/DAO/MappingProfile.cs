﻿using AutoMapper;
using BusinessObjects.Request;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;
using BussinessObjects.Request;
using BussinessObjects.Response;

namespace DAO
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RequestPartyHostDTO, PartyHost>();
            CreateMap<RequestRegisteredUserDTO, RegisteredUser>();
            CreateMap<RequestAccountLoginDTO, Admin>();
            CreateMap<RequestAccountLoginDTO, RegisteredUser>();
            CreateMap<RequestAccountLoginDTO, staff>();
            CreateMap<RequestAccountLoginDTO, PartyHost>();
            CreateMap<RequestStaffDTO, staff>();
            CreateMap<RequestPackageCreateDTO, Package>();
            CreateMap<RequestPackageUpdateDTO, Package>();
            CreateMap<RequestConfigDTO, Config>();
            CreateMap<RequestUpdateConfigDTO, Config>();
            CreateMap<RequestPostDTO, Post>();
            CreateMap<RequestVoucherDTO, Voucher>();
            CreateMap<RequestFeedbackDTO, Feedback>();
            CreateMap<Feedback, ResponseFeedbackDTO>();
            CreateMap<ResponseFeedbackDTO, Feedback>();
            CreateMap<RequestBookingRoomDTO, Booking>();
        }
    }
}
