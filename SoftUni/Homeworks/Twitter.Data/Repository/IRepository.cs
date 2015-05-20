using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter.Data.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> All();

        T Find(object id);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);

        T Remove(object id);

        void SaveChanges();
    }
}
