using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Models.Context
{
    public class WarPlannerContext : DbContext, IWarPlannerContext
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private IDbContextTransaction? dbContextTransaction;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                             PROPERTIES                            *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public DbSet<Calendar> Calendars { get; set; }

        public DbSet<Clan> Clans { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Guild> Guilds { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Time> Times { get; set; }

        public DbSet<WarStatistic> WarStatistics { get; set; }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public WarPlannerContext(DbContextOptions options) : base(options) { }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public void BeginTransaction()
        {
            dbContextTransaction = Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            dbContextTransaction?.Commit();
        }

        public void DisposeTransaction()
        {
            dbContextTransaction?.Dispose();
        }

        public void RollbackTransaction()
        {
            dbContextTransaction?.Rollback();
        }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
    }
}
