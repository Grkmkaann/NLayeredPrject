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

        List<T> GetAll(Expression<Func<T, bool>> expression=null);
        T Get(Expression<Func<T,bool>> expression);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);


    }
}
