using OA.DomainEntities.Models;
using OA.Repository.RepositoryInterface;
using OA.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceModels
{
    public class PaymentDetailsService : IPaymentDetailsService
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public PaymentDetailsService(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }

        public Task<bool> AddPaymentDetails(PaymentDetails model)
        {
            var result = _paymentDetailsRepository.AddPaymentDetails(model);
            return result;
        }

        public async Task<IQueryable<PaymentDetails>> GetAll()
        {
            var result = await _paymentDetailsRepository.GetAll();
            return result.AsQueryable();
        }

        public async Task<PaymentDetails> GetPaymentDetailsById(string id)
        {
            var result = await _paymentDetailsRepository.GetPaymentDetailsById(id);
            return result;
        }

        public async Task<bool> VerifyEmailAdress(string email)
        {
            // code
            //throw new NotImplementedException();
            var result = await _paymentDetailsRepository.VerifyEmailAddres(email);
            return result;
        }
    }
}
