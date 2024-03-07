using BussinessObjects.Request;
using BussinessObjects.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFeedBackRepository
    {
        Task<ResponseFeedbackDTO> GetFeedbackById(int feedback);
        Task<bool> CreateFeedback(RequestFeedbackDTO feedback);
    }
}
