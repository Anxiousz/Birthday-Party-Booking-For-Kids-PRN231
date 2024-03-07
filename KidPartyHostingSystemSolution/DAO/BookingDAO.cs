using AutoMapper;
using BusinessObjects;
using BussinessObjects;
using BussinessObjects.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BookingDAO
    {
        private static BookingDAO instance = null;
        private readonly PHSContext dbContext = null;
        public BookingDAO()
        {
            if (dbContext == null)
            {
                dbContext = new PHSContext();
            }
        }

        public static BookingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingDAO();
                }
                return instance;
            }
        }
        public List<Booking> GetOrders()
        {
            return dbContext.Bookings.ToList();
        }

        public async Task<bool> BookingRoom(RequestBookingRoomDTO request)
        {
            try
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<MappingProfile>();
                });
                IMapper mapper = config.CreateMapper();
                Booking booking = mapper.Map<Booking>(request);


                dbContext.Bookings.Add(booking);

                if (await dbContext.SaveChangesAsync() > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
