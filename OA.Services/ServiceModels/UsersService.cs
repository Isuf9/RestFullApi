using OA.DomainEntities.Models;
using OA.Repository.RepositoryInterface;
using OA.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceModels
{
    public class UsersService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UsersService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Users> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            return user;
        }
        public async Task<Users> Create(Users user)
        {
            var result = await _userRepository.Create(user);
            return result;
        }
        public bool Update(Users user)
        {
            var result =  _userRepository.Update(user);
            return result;
        }
        public async Task<bool> DeleteForever(string id)
        {
            var result = await _userRepository.DeleteForever(id);
            return result;
        }

    }
}
