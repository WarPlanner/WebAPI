using Models.Context;

namespace WebAPI.App_Start
{
    public class DependencyInjectionConfig
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           STATIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public static void AddScope(IServiceCollection services)
        {
            services.AddScoped<IWarPlannerContext, WarPlannerContext>();
        }
    }
}
