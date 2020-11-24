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
    public class PaymentDetails : IPaymentDetails
    {
        private readonly IPaymentDetailsRepository _paymentDetailsRepository;
        public PaymentDetails(IPaymentDetailsRepository paymentDetailsRepository)
        {
            _paymentDetailsRepository = paymentDetailsRepository;
        }

        public async Task<IQueryable<PaymentDetailsForClient>> GetAll()
        {
            var result = await _paymentDetailsRepository.GetAll();
            return result.AsQueryable();
        }
    }
}
