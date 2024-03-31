using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
    where TContext : DbContext, new()
    where TEntity : class, IEntity, new()

{
    public void Add(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
        }
    }

    public void Update(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
        }
    }

    public void Delete(TEntity entity)
    {
        using (TContext context = new TContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
        }
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public IList<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        throw new NotImplementedException();
    }
}
