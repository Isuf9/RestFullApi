using OA.DomainEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryInterface
{
    public interface IUserRepository /*<T> : IReposotory<T> where T : class*/
    {
        Task<Users> GetUserById(int id);
        Task<Users> Create(Users user);
        bool Update(Users user);
        Task<bool> DeleteForever(string id);

    }
}
