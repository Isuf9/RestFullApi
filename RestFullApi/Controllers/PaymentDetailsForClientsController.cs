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
        private readonly IPaymentDetails _paymentDetials;
        public PaymentDetailsForClientsController(AnuglarAppContext context, IPaymentDetails paymentDetails)
        {
            _context = context;
            _paymentDetials = paymentDetails;
        }

        // GET: api/PaymentDetailsForClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetailsForClient>>> GetPaymentDetailsForClients()
        {
            //return await _context.PaymentDetailsForClients.ToListAsync();
            var result = await _paymentDetials.GetAll();
            return Ok(result);
        }

        // GET: api/PaymentDetailsForClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetailsForClient>> GetPaymentDetailsForClient(int id)
        {
            var paymentDetailsForClient = await _context.PaymentDetailsForClients.FindAsync(id);

            if (paymentDetailsForClient == null)
            {
                return NotFound();
            }

            return paymentDetailsForClient;
        }

        // PUT: api/PaymentDetailsForClients/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetailsForClient(int id, PaymentDetailsForClient paymentDetailsForClient)
        {
            if (id != paymentDetailsForClient.Pmid)
            {
                return BadRequest();
            }

            _context.Entry(paymentDetailsForClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaymentDetailsForClientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PaymentDetailsForClients
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PaymentDetailsForClient>> PostPaymentDetailsForClient(PaymentDetailsForClient paymentDetailsForClient)
        {
            _context.PaymentDetailsForClients.Add(paymentDetailsForClient);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PaymentDetailsForClientExists(paymentDetailsForClient.Pmid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPaymentDetailsForClient", new { id = paymentDetailsForClient.Pmid }, paymentDetailsForClient);
        }

        // DELETE: api/PaymentDetailsForClients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentDetailsForClient>> DeletePaymentDetailsForClient(int id)
        {
            var paymentDetailsForClient = await _context.PaymentDetailsForClients.FindAsync(id);
            if (paymentDetailsForClient == null)
            {
                return NotFound();
            }

            _context.PaymentDetailsForClients.Remove(paymentDetailsForClient);
            await _context.SaveChangesAsync();

            return paymentDetailsForClient;
        }

        private bool PaymentDetailsForClientExists(int id)
        {
            return _context.PaymentDetailsForClients.Any(e => e.Pmid == id);
        }
    }
}
