﻿using System;
using System.Collections.Generic;

namespace BussinessObjects
{
    public partial class PartyHost
    {
        public PartyHost()
        {
            MenuPartyHosts = new HashSet<MenuPartyHost>();
            Posts = new HashSet<Post>();
            Rooms = new HashSet<Room>();
            Vouchers = new HashSet<Voucher>();
        }

        public int PartyHostId { get; set; }
        public int? StaffId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int? PackageId { get; set; }
        public string Role { get; set; }
        public int? Status { get; set; }

        public virtual Package Package { get; set; }
        public virtual staff Staff { get; set; }
        public virtual ICollection<MenuPartyHost> MenuPartyHosts { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
    }
}
