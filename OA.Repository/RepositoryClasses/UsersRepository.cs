using OA.DomainEntities.Models;
using OA.Repository.Models;
using OA.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryClasses
{
    public class UsersRepository : IUserRepository
    {
        private readonly AnuglarAppContext _context;
        private readonly IReposotory<Users> _repository;
        public UsersRepository
            (
            AnuglarAppContext context,
            IReposotory<Users> repository
            )
        {
            _context = context;
            _repository = repository;
        }

        public async Task<Users> Create(Users user)
        {
            var result =await _repository.Create(user);
            return result;
        }

        public bool DeleteForever(Users user)
        {
            var result = _repository.Delete(user);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Users> GetUserById(int id)
        {
            //var user =_context.Users.Where(x => x.id == id.ToString()).FirstOrDefault();
            var user =await _repository.GetById(id.ToString());
            return user;
        }

        public bool Update(Users user)
        {
           var result =  _repository.Update(user);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
