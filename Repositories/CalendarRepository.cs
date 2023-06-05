using Interfaces.Repositories;
using Models;
using Models.Context;

namespace Repositories
{
    public class CalendarRepository : BaseRepository.BaseRepository, ICalendarRepository
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarRepository(IWarPlannerContext context) : base(context) { }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public List<Calendar> GetAll()
        {
            try
            {
                return Context.Set<Calendar>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Calendar Save(Calendar domain)
        {
            try
            {
                domain.CreatedAt = DateTimeOffset.Now;
                domain.UpdatedAt = domain.CreatedAt;

                return Insert(domain);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Calendar domain)
        {
            try
            {
                domain.UpdatedAt = DateTimeOffset.UtcNow;
                Update<Calendar>(domain);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
