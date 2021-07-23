﻿using GenericApi.Model.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GenericApi.Model.IoC
{
    public static class ModelRegistry
    {
        public static void AddModelRegistry(this IServiceCollection services)
        {
            services.AddScoped<IDocumentRepository,DocumentRepository>();
            services.AddScoped<IWorkShopRepository,WorkShopRepository>();
            services.AddScoped<IWorkShopMemberRepository,WorkShopMemberRepository>();
            services.AddScoped<IWorkShopDayRepository,WorkShopDayRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
