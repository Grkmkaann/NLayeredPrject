using DataAccess.Abstract.Repositories;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.ORMs.EntityFramework.Base
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
        where TEntity : class, IEntity, new()
        where TContext: DbContext, new()
    {


        public List<TEntity> GetAll()
        {
            using (TContext context = new TContext())
            {
                try
                {
                    return context.Set<TEntity>().ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
             
            }
        }


        public bool Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;
            }
        }


        public bool Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
           
            }
        }

      
        public bool Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
                return true;
              
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(expression);
            }
        }
    }
}
