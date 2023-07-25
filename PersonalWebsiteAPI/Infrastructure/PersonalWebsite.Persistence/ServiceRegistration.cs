using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Persistence.Context;
using PersonalWebsiteAPI.Persistence.Repositories;

namespace PersonalWebsiteAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<PersonalWebsiteAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            services.AddScoped<IBlogReadRepository,BlogReadRepository>();
            services.AddScoped<IBlogWriteRepository,BlogWriteRepository>();
            services.AddScoped<IUserReadRepository,UserReadRepository>();
            services.AddScoped<IUserWriteRepository,UserWriteRepository>();
            services.AddScoped<IProjectReadRepository,ProjectReadRepository>();
            services.AddScoped<IProjectWriteRepository,ProjectWriteRepository>();
            services.AddScoped<ICategoryReadRepository,CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository,CategoryWriteRepository>();
        }
    }
}
