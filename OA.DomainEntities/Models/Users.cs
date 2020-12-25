using System;
using System.Collections.Generic;
using System.Text;

namespace OA.DomainEntities.Models
{
    public class Users
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sureName { get; set; }
        public DateTime createOnDate { get; set; }
        public DateTime updateOnDate { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
