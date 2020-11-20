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
        public async Task<IEnumerable<PaymentDetailsForClient>> GetAll()
        {
            return await _dbContext.PaymentDetailsForClients.Where(x => x.Pmid != null).ToListAsync();
        }
    }
}
