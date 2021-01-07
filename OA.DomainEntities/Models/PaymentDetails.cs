using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OA.DomainEntities.Models
{
    public class PaymentDetails
    {
        [Key]
        public string PaymentId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpariationDate { get; set; }
        public string Cvv { get; set; }
    }
}
