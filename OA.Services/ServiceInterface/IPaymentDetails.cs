using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceInterface
{
    public interface IPaymentDetails
    {
        Task<IQueryable<PaymentDetailsForClient>> GetAll();
    }
}
