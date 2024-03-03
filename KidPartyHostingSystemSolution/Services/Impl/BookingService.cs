using Repository.Impl;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Services.Impl
{
    public class BookingService : IBookingService
    {
        private IBookingRepository bookingRepository;

        public BookingService()
        {
            bookingRepository = new BookingRepository();
        }
        public List<Booking> GetOrders() => bookingRepository.GetOrders();

    }
}
