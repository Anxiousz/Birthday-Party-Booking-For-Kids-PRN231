using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Response
{
    public class ResponseTransactionDTO
    {
        public int TransactionId { get; set; }
        public int? PaymentId { get; set; }

        public Payment? Payment { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}
