using OA.Repository.RepositoryInterface;
using OA.Services.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Services.ServiceModels
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IReposotory<T> _resopository;
        public Service(IReposotory<T> resopository)
        {
            _resopository = resopository;
        }
        public async Task<T> Create(T model)
        {
            var result = await _resopository.Create(model);
            return result;
        }

        public async Task<bool> Delete(T model)
        {
            var result = await _resopository.Delete(model);
            return result;
        }

        public async Task<T> GetById(string id)
        {
            var result =await _resopository.GetById(id);
            return result;
        }

        public void SaveChanges()
        {
            _resopository.SaveChanges();
        }

        public void SaveChangesAsync()
        {
            _resopository.SaveChangesAsync();
        }

        public async Task<T> Update(T model)
        {
            var result =await _resopository.Update(model);
            return result;
        }
    }
}
