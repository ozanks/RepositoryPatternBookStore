using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryBookStore.Models
{
    interface IGenericRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T FindById(int entityId);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
