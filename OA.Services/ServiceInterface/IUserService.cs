using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceInterface
{
    public interface IUserService
    {
        Task<Users> GetUserById(int id);
    }
}
