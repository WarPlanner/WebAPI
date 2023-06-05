
using Models;

namespace Interfaces.Services
{
    public interface ICalendarService
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public Calendar Create(Calendar domain);

        public List<Calendar> GetAll();

        public bool Update(Calendar domain);
    }
}
