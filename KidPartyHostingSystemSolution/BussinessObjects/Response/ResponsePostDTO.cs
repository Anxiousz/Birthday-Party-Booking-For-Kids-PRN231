using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Response
{
    public class ResponsePostDTO
    {
        public int PostId { get; set; }
        public string Context { get; set; } = string.Empty; 
        public string Title { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public string Image { get; set; } = string.Empty;

        public PartyHost? CreatedByNavigation { get; set; }
        public List<Feedback>? Feedbacks { get; set; }
    }
}
