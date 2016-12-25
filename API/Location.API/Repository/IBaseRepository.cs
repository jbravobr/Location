using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Location.API.Repository
{
  public  interface IBaseRepository<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> Get(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}
