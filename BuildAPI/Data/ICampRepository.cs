using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAPI.Data
{
    public interface ICampRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}
