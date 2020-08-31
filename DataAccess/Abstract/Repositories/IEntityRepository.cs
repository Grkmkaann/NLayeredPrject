using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace DataAccess.Abstract.Repositories
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {

        List<T> GetAll();
        T Get(Expression<Func<T,bool>> expression);
        bool Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
