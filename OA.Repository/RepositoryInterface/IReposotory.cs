using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryInterface
{
    public interface IReposotory<T> where T : class
    {
        Task<T> GetById(string id);
        Task<T> Create(T model);
        Task<T> Update(T model);
        Task<bool> Delete(T model);
        void SaveChangesAsync();
        void SaveChanges();

    }
}
