using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.DomainEntities.Models;
using OA.Repository.Models;
using OA.Services.ServiceInterface;

namespace RestFullApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailsForClientsController : ControllerBase
    {
        private readonly IPaymentDetailsService _paymentDetials;
        private readonly IService<PaymentDetails> _service;
        public PaymentDetailsForClientsController
            (
                IPaymentDetailsService paymentDetails,
                IService<PaymentDetails> service
            )
                {
                    _paymentDetials = paymentDetails;
                    _service = service;
                }

       

        // GET: api/PaymentDetailsForClients
        [Route("getAll")]
        [HttpGet]
        public async Task<ActionResult<IQueryable<PaymentDetailsForClient>>> GetPaymentDetailsForClients()
        {
            var result = await _paymentDetials.GetAll();

            if(result.Count() >= 0)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
            
        }

        // GET: api/PaymentDetailsForClients/id
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetails>> GetPaymentDetailsById(string id)
        {
            //from general service 
            var result = await _service.GetById(id.ToString());
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // POST: api/PaymentDetailsForClients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostPaymentDetailsForClient(PaymentDetails model)
        {
            var result = await _service.Create(model);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPost("{email}")]
        public async Task<IActionResult> VerifyEmailAddres(string email)
        {
            var result = await _paymentDetials.VerifyEmailAdress(email);
            if(result == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
        [HttpPut]
        public  IActionResult UpdateInfoOfPaymentDetails(PaymentDetails model)
        {
            var result =  _service.Update(model);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForever(string id)
        {
            var result = await _service.Delete(id);
            if(result == true)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
