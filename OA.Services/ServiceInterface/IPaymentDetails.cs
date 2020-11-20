using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceInterface
{
    public interface IPaymentDetails
    {
        Task<IEnumerable<PaymentDetailsForClient>> GetAll();
    }
}
