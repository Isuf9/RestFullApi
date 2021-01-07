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
        private readonly AnuglarAppContext _context;
        private readonly IPaymentDetailsService _paymentDetials;
        private readonly IService<PaymentDetails> _service;
        public PaymentDetailsForClientsController(AnuglarAppContext context,
            IPaymentDetailsService paymentDetails,
            IService<PaymentDetails> service)
        {
            _context = context;
            _paymentDetials = paymentDetails;
            _service = service;
        }

        // GET: api/PaymentDetailsForClients
        [HttpGet]
        public async Task<ActionResult<IQueryable<PaymentDetailsForClient>>> GetPaymentDetailsForClients()
        {
            //return await _context.PaymentDetailsForClients.ToListAsync();
             var result = await _paymentDetials.GetAll();
            //var result = await _service.
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
            //from self service
           // var result = await _paymentDetials.GetPaymentDetailsById(id);

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
        public async Task<ActionResult<PaymentDetailsForClient>> PostPaymentDetailsForClient(PaymentDetailsForClient paymentDetailsForClient)
        {
            var result =await _paymentDetials.AddPaymentDetails(paymentDetailsForClient);

            if(result == true)
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
    }
}
