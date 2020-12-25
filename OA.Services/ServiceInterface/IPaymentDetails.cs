using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceInterface
{
    public interface IPaymentDetails /*: IService*/
    {
        Task<IQueryable<PaymentDetailsForClient>> GetAll();
        Task<PaymentDetailsForClient> GetPaymentDetailsById(int id);
        Task<bool> AddPaymentDetails(PaymentDetailsForClient model);
        Task<bool> VerifyEmailAdress(string email);
    }
}
