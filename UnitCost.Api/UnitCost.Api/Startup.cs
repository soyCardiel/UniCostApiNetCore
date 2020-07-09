using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UnitCost.Dao.Catalogs.Contract;
using UnitCost.Dao.Catalogs.Impl;
using UnitCost.Domain.Catalogs.Contract;
using UnitCost.Domain.Catalogs.Impl;
using UnitCost.DBMigrations;

namespace UnitCost.Api
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
            services.AddControllers();
            CustomConfig(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // using cors
            app.UseCors("UnitCostCors");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void CustomConfig(IServiceCollection services)
        {
            // creating cors filters
            services.AddCors(opts => { opts.AddPolicy("UnitCostCors", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); });
            services.AddDbContext<UnitCostAppContext>(opts => opts.UseMySql(Configuration.GetConnectionString("DatabaseConnection")));

            services.AddScoped<IUserDomain, UserDomain>();
            services.AddScoped<IUserDao, UserDao>();
        }
    }
}
