using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryInterface
{
    public interface IPaymentDetailsRepository  /*<T> : IReposotory<T> where T : class*/
    {
        Task<IQueryable<PaymentDetailsForClient>> GetAll();
        Task<PaymentDetailsForClient> GetPaymentDetailsById(int id);
        Task<bool> AddPaymentDetails(PaymentDetailsForClient model);
        Task<bool> VerifyEmailAddres(string email);
    }
}
