using TestApi.DAL.Abstract;

namespace TestApi.DAL
{
    public class Repository : IMyRepository
    {
        private readonly MyContext _MyContext;

        public Repository(MyContext MyContext)
        {
            _MyContext = MyContext;
        }

        public TEntity Add<TEntity>(TEntity entity) where TEntity : class
        {
            TEntity result = _MyContext.Set<TEntity>().Add(entity).Entity;
            _MyContext.SaveChanges();
            return result;
        }
        public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
        {
            _MyContext.Set<TEntity>().AddRange(entities);
            _MyContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : class =>
            _MyContext.Set<TEntity>();

        public TEntity GetById<TEntity>(Guid id) where TEntity : class =>
            _MyContext.Set<TEntity>().Find(id);

        public TEntity Remove<TEntity>(TEntity entity) where TEntity : class
        {
            TEntity result = _MyContext.Set<TEntity>().Remove(entity).Entity;
            _MyContext.SaveChanges();
            return result;
        }

        public TEntity Update<TEntity>(TEntity entity) where TEntity : class
        {
            TEntity result = _MyContext.Set<TEntity>().Update(entity).Entity;
            _MyContext.SaveChanges();
            return result;
        }
    }
}
