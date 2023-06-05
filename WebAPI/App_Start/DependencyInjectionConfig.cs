using Interfaces.Maps;
using Interfaces.Repositories;
using Interfaces.Services;
using Maps;
using Models.Context;
using Repositories;
using Services;

namespace WebAPI.App_Start
{
    public class DependencyInjectionConfig
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           STATIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public static void AddScope(IServiceCollection services)
        {
            // Global context
            services.AddScoped<IWarPlannerContext, WarPlannerContext>();

            // Calendar
            services.AddScoped<ICalendarMap, CalendarMap>();
            services.AddScoped<ICalendarService, CalendarService>();
            services.AddScoped<ICalendarRepository, CalendarRepository>();
        }
    }
}
