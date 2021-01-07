using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceInterface
{
    public interface IPaymentDetailsService /*: IService*/
    {
        Task<IQueryable<PaymentDetails>> GetAll();
        Task<PaymentDetails> GetPaymentDetailsById(string id);
        Task<bool> AddPaymentDetails(PaymentDetails model);
        Task<bool> VerifyEmailAdress(string email);
    }
}
