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
        T Update(T model);
        Task<bool> Delete(string id);
        void SaveChangesAsync();
        void SaveChanges();

    }
}
