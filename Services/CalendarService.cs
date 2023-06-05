using Interfaces.Repositories;
using Interfaces.Services;
using Models;

namespace Services
{
    public class CalendarService : ICalendarService
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly ICalendarRepository repository;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarService(ICalendarRepository repository)
        {
            this.repository = repository;
        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public Calendar Create(Calendar domain)
        {
            return repository.Save(domain);
        }

        public List<Calendar> GetAll()
        {
            return repository.GetAll();
        }

        public bool Update(Calendar domain)
        {
            return repository.Update(domain);
        }
    }
}
