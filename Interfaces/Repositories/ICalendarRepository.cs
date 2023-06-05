using Models;

namespace Interfaces.Repositories
{
    public interface ICalendarRepository
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public List<Calendar> GetAll();

        public bool Update(Calendar domain);

        public Calendar Save(Calendar domain);
    }
}
