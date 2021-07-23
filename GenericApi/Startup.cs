using GenericApi.Bl.Config;
using GenericApi.Config;
using GenericApi.Model.IoC;
using GenericApi.Services.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GenericApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region External Dependencies Configs

            services.ConfigSqlServerDbContext(Configuration.GetConnectionString("DefaultConnection"));
            services.AddControllers(options => options.EnableEndpointRouting = false)
                .ConfigFluentValidation();
            services.ConfigAutoMapper();
            services.AddAppOData();
            services.ConfigSerilog();

            #endregion

            #region App Registries

            services.AddServiceRegistry();
            services.AddModelRegistry();

            #endregion

            #region Api Libraries

            services.AddSwagger();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAppSwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMvc(routeBuilder => routeBuilder.UseAppOData());
        }
    }
}
