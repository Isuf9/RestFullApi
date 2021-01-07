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
        Task<IQueryable<PaymentDetails>> GetAll();
        Task<PaymentDetails> GetPaymentDetailsById(string id);
        Task<bool> AddPaymentDetails(PaymentDetails model);
        Task<bool> VerifyEmailAddres(string email);
    }
}
