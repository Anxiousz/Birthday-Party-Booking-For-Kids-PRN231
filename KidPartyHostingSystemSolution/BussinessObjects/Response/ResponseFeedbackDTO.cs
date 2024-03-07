using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Response
{
    public class ResponseFeedbackDTO
    {
        public int FeedbackId { get; set; }
        public int? PostId { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int? Rating { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }

        public RegisteredUser? CreatedByNavigation { get; set; }
        public Post? Post { get; set; }
    }
}
