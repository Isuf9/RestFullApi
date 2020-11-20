using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryInterface
{
    public interface IPaymentDetailsRepository
    {
        Task<IEnumerable<PaymentDetailsForClient>> GetAll();
    }
}
