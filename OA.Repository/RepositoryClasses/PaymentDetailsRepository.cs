using OA.DomainEntities.Models;
using OA.Repository.Models;
using OA.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryClasses
{
    public class PaymentDetailsRepository : IPaymentDetailsRepository
    {
        private readonly AnuglarAppContext _dbContext;
        public PaymentDetailsRepository(AnuglarAppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AddPaymentDetails(PaymentDetailsForClient model)
        {
            var result = _dbContext.PaymentDetailsForClients.Add(model);
            var saveResult = await _dbContext.SaveChangesAsync();
            if (saveResult > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IQueryable<PaymentDetailsForClient>> GetAll()
        {
            var result = _dbContext.PaymentDetailsForClients.AsQueryable();
            //var x = result.AsQueryable;
            return result;
        }

        public async Task<PaymentDetailsForClient> GetPaymentDetailsById(int id)
        {
            var result = _dbContext.PaymentDetailsForClients.Where(x => x.Pmid == id).FirstOrDefault();
            var x = result;
            return  result;
        }

        public async Task<bool> VerifyEmailAddres(string email)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://email-checker.p.rapidapi.com/verify/v1?email=isufbajraktari5%40gmail.com"),
                Headers =
    {
        { "x-rapidapi-key", "SIGN-UP-FOR-KEY" },
        { "x-rapidapi-host", "email-checker.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                //response.EnsureSuccessStatusCode();
                //var body = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(body);
            
            if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    return true;
                }
                else
                {
                    return false;
                }
                
               // Console.WriteLine(body);
            }
        }
    }
}
