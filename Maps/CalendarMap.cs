using Interfaces.Maps;
using Interfaces.Services;
using Models;
using ViewModels;

namespace Maps
{
    public class CalendarMap : ICalendarMap
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                               FIELDS                              *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private readonly ICalendarService service;

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                            CONSTRUCTORS                           *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarMap(ICalendarService service)
        {
            this.service = service;
        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           PUBLIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public CalendarViewModel Create(CalendarViewModel viewModel)
        {
            Calendar calendar = ViewModelToDomain(viewModel);
            return DomainToViewModel(service.Create(calendar));
        }

        public List<CalendarViewModel> GetAll()
        {
            return DomainToViewModel(service.GetAll());
        }

        public bool Update(CalendarViewModel viewModel)
        {
            Calendar calendar = ViewModelToDomain(viewModel);
            return service.Update(calendar);
        }

        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           STATIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        private static CalendarViewModel DomainToViewModel(Calendar domain)
        {
            return new CalendarViewModel(domain.GuildId, domain.Id)
            {
                ChannelId = domain.ChannelId,
                MessageId = domain.MessageId,
            };
        }

        private static List<CalendarViewModel> DomainToViewModel(List<Calendar> domain)
        {
            return domain
                .Select(DomainToViewModel)
                .ToList();
        }

        private static Calendar ViewModelToDomain(CalendarViewModel viewModel)
        {
            return new Calendar
            {
                GuildId = viewModel.GuildId,
                Id = viewModel.Id,
                ChannelId = viewModel.ChannelId,
                MessageId = viewModel.MessageId,
            };
        }
    }
}
