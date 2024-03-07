using BussinessObjects;
using BussinessObjects.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookingService
    {
        public List<Booking> GetOrders();
        Task<bool> BookingRoom(RequestBookingRoomDTO request);
    }
}
