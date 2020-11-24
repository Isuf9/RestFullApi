using OA.DomainEntities.Models;
using OA.Repository.Models;
using OA.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public async Task<IQueryable<PaymentDetailsForClient>> GetAll()
        {
            var result = _dbContext.PaymentDetailsForClients.AsQueryable();
            //var x = result.AsQueryable;
            return result;
        }
    }
}
