using OA.Repository.Models;
using OA.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA.Repository.RepositoryClasses
{
    public class Repository<T> : IReposotory<T> where T : class
    {
        private readonly AnuglarAppContext _context;
        public Repository(AnuglarAppContext context)
        {
            _context = context;
        }
        public async Task<T> GetById(string id)
        {
            var user = _context.Set<T>().Find(id);

            return user;
        }
        public async Task<T> Create(T model)
        {
            var user = _context.Set<T>().Add(model);
            SaveChangesAsync();

            return user.Entity;
        }

        public async Task<bool> Delete(T model)
        {
            var user = _context.Set<T>().Remove(model);
            SaveChangesAsync();
            return true;
        }
        public async Task<T> Update(T model)
        {
            var userEdited = _context.Set<T>().Update(model);
            SaveChangesAsync();
            return userEdited.Entity;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

    }
}
