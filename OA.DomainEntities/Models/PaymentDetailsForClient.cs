using System;
using System.Collections.Generic;

#nullable disable

namespace OA.DomainEntities.Models
{
    public class PaymentDetailsForClient
    {
        public int Pmid { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpariationDate { get; set; }
        public string Cvv { get; set; }
    }
}
