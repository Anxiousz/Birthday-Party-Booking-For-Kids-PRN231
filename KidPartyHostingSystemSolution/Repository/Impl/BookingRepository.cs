using BussinessObjects;
using BussinessObjects.Request;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Impl
{
    public class BookingRepository : IBookingRepository
    {
        private BookingDAO bookingDAO;
        public BookingRepository()
        {
            bookingDAO = new BookingDAO();
        }
        public List<Booking> GetOrders() => bookingDAO.GetOrders();
        public Task<bool> BookingRoom(RequestBookingRoomDTO request) => bookingDAO.BookingRoom(request);
    }
}
