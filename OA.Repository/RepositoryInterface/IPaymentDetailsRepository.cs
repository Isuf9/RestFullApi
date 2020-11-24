using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryInterface
{
    public interface IPaymentDetailsRepository
    {
        Task<IQueryable<PaymentDetailsForClient>> GetAll();
    }
}
