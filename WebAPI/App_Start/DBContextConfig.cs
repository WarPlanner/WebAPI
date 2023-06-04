using Microsoft.EntityFrameworkCore;
using Models.Context;

namespace WebAPI.App_Start
{
    public class DBContextConfig
    {
        /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\
        |*                           STATIC METHODS                          *|
        \* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

        public static void Initialize(IServiceCollection services, IConfiguration configuration, IWebHostEnvironment env)
        {
            DbContextOptionsBuilder optionsBuilder = new();

            if (env.IsDevelopment()) optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevConnection"));
            else if (env.IsProduction()) optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProdConnection"));
            else throw new Exception($"Environment '{env.EnvironmentName}' is unknown");

            WarPlannerContext context = new(optionsBuilder.Options);

            if (!context.Database.CanConnect()) throw new Exception("Cannot connect to database");

            services.AddDbContext<WarPlannerContext>(options =>
            {
                if (env.IsDevelopment()) options.UseSqlServer(configuration.GetConnectionString("DevConnection"));
                else if (env.IsProduction()) options.UseSqlServer(configuration.GetConnectionString("ProdConnection"));
            });
        }
    }
}
