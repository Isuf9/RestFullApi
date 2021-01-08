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

        public async Task<bool> AddPaymentDetails(PaymentDetails model)
        {
            var result = _dbContext.PaymentDetails.Add(model);
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

        public async Task<IQueryable<PaymentDetails>> GetAll()
        {
            var result = _dbContext.PaymentDetails.AsQueryable();
            return result;
        }

        public async Task<PaymentDetails> GetPaymentDetailsById(string id)
        {
            var result = await _dbContext.PaymentDetails.Where(x => x.PaymentId == id).FirstOrDefaultAsync();
            var x = result;
            return  result;
        }

        public Task<bool> VerifyEmailAddres(string email)
        {
            throw new NotImplementedException();
        }

        //    public async Task<bool> VerifyEmailAddres(string email)
        //    {
        //        var client = new HttpClient();
        //        var request = new HttpRequestMessage
        //        {
        //            Method = HttpMethod.Post,
        //            RequestUri = new Uri("https://email-checker.p.rapidapi.com/verify/v1?email=isufbajraktari5%40gmail.com"),
        //            Headers =
        //{
        //    { "x-rapidapi-key", "SIGN-UP-FOR-KEY" },
        //    { "x-rapidapi-host", "email-checker.p.rapidapi.com" },
        //},
        //        };
        //        using (var response = await client.SendAsync(request))
        //        {
        //            //response.EnsureSuccessStatusCode();
        //            //var body = await response.Content.ReadAsStringAsync();
        //            //Console.WriteLine(body);

        //        if (response.IsSuccessStatusCode)
        //            {
        //                response.EnsureSuccessStatusCode();
        //                var body = await response.Content.ReadAsStringAsync();
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }

        //           // Console.WriteLine(body);
        //        }
        //    }
    }
}
