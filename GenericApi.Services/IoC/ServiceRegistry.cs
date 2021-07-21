using GenericApi.Services.Services;
using Microsoft.Extensions.DependencyInjection;


namespace GenericApi.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServiceRegistry(this IServiceCollection services)
        {
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IWorkShopService, WorkShopService>();
            services.AddScoped<IWorkShopMemberService, WorkShopMemberService>();
            services.AddScoped<IWorkShopDayService, WorkShopDayService>();
        }
    }
}
