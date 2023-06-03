using Microsoft.EntityFrameworkCore;

namespace Models.Context
{
    public interface IWarPlannerContext
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        /* * * * * * * * * * * * * * * * * *\
        |*             ABSTRACT            *|
        \* * * * * * * * * * * * * * * * * */

        public abstract void BeginTransaction();

        public abstract void CommitTransaction();

        public abstract void DisposeTransaction();

        public abstract void RollbackTransaction();

        public abstract void SaveChanges();

        public DbSet<T> Set<T>() where T : class;
    }
}
