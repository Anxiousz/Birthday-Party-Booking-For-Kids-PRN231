using BussinessObjects.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace KidPartyHostingSystemAPI.Controllers
{
    [Route("api/v1/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class BookingController : ControllerBase
    {
        private IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpPost]
        public async Task<IActionResult> BookingRoom(RequestBookingRoomDTO bookingRoomDTO)
        {
            try
            {
                var status = await _bookingService.BookingRoom(bookingRoomDTO);
                if (!status)
                {
                    return BadRequest($"Failed to booking room");
                }

                return Ok("Booking successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return BadRequest("Invalid Request");
            }
        }
    }
}
