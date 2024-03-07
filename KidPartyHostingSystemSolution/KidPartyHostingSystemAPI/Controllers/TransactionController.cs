﻿using BussinessObjects;
using BussinessObjects.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace KidPartyHostingSystemAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/[controller]/[action]")]
    public class TransactionController : ControllerBase
    {
        private ITransactionBookingService _transactionService;
        public TransactionController(ITransactionBookingService transactionService)
        {
            _transactionService = transactionService;
        }


        [HttpGet]
        public async Task<IActionResult> ViewTransaction(int id)
        {
            try
            {

                ResponseTransactionDTO? transactionDTO = await _transactionService.GetTransactionById(id);

                if (transactionDTO == null)
                {
                    return BadRequest($"Transaction with id = {id} doesn't exist");
                }

                return Ok(transactionDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                return BadRequest("Invalid Request");
            }
        }
    }
}
