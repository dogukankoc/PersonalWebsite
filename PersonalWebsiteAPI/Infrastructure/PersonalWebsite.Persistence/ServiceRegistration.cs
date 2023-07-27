using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PersonalWebsiteAPI.Application.Repositories;
using PersonalWebsiteAPI.Application.Services;
using PersonalWebsiteAPI.Domain.Entities;
using PersonalWebsiteAPI.Persistence.Context;
using PersonalWebsiteAPI.Persistence.Repositories;
using PersonalWebsiteAPI.Persistence.Services;

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

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
