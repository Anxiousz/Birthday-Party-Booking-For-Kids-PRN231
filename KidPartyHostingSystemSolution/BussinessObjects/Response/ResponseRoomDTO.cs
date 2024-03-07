using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Response
{
    public class ResponseRoomDTO
    {
        public int? RoomId { get; set; }
        public int? PartyHostId { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string RoomType { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Location { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Note { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int Status { get; set; }

        public PartyHost? PartyHost { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}
