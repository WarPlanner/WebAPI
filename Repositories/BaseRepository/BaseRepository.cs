using Microsoft.EntityFrameworkCore.ChangeTracking;
using Models.Context;

namespace Repositories.BaseRepository
{
    public class BaseRepository
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public IWarPlannerContext Context { get; private set; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public BaseRepository(IWarPlannerContext context)
        {
            Context = context;
        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public void Delete<T>(T domain) where T : class
        {
            Context.BeginTransaction();

            Context.Set<T>().Remove(domain);

            Context.SaveChanges();
            Context.CommitTransaction();

            Context.DisposeTransaction();
        }

        public T Insert<T>(T domain) where T : class
        {
            Context.BeginTransaction();

            EntityEntry<T> addedDomain = Context.Set<T>().Add(domain);

            Context.SaveChanges();
            Context.CommitTransaction();

            Context.DisposeTransaction();

            return addedDomain.Entity;
        }

        public void Update<T>(T domain) where T : class
        {
            Context.BeginTransaction();

            Context.Set<T>().Update(domain);

            Context.SaveChanges();
            Context.CommitTransaction();

            Context.DisposeTransaction();
        }
    }
}
