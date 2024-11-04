using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using App.UserAPI.Helpers.AutoMapper;
using App.UserAPI.Business.Layer.Implementation;
using App.UserAPI.Business.Layer.Interfaces;
using Microsoft.EntityFrameworkCore;
using App.UserAPI.Service.Layer.Implementation;
using App.UserAPI.Service.Layer.Interfaces;
using Shared.Encryption.Interface;
using Shared.Encryption.Implementation;
using Shared.Entities.Infrastructure.Interface;
using Shared.Entities.Entities;
using Shared.Context.Implementation;
using Shared.Context.Interface;

namespace App.UserAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIProjectDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IContextHelper, ContextHelper>();
            return services;
        }
        public static IServiceCollection AddBusinessDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IMasterBusiness, MasterBusiness>();
            services.AddScoped<IAccountBusiness, AccountBusiness>();
            return services;
        }
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IMasterService, MasterService>();
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MatrimonyCoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MatrimonyCore"),
                b => b.MigrationsAssembly(typeof(MatrimonyCoreContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddTransient<IApplicationDBContext>(provider => provider.GetService<MatrimonyCoreContext>());
            return services;
        }
        public static IServiceCollection AddEncryptionDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            return services;
        }
        public static IServiceCollection AddMapperDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            var mapperConfig = new MapperConfiguration(mc => {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            return services;
        }
    }
}
