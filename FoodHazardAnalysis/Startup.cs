using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodHazardAnalysis.Interfaces.DbContext;
using FoodHazardAnalysis.Interfaces.Repositories;
using FoodHazardAnalysis.Models;
using FoodHazardAnalysis.Repositories;
using FoodHazardAnalysis.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace FoodHazardAnalysis
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<FoodHazardBotDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddSingleton<IContext, FoodHazardBotDBContext>();
            services.AddTransient<IContext, FoodHazardBotDBContext>();
            services.AddSingleton<IRepository<Products>, ProductRepository>();
            services.AddTransient<IRepository<Products>, ProductRepository>();
            services.AddSingleton<IRepository<Eadditives>, EAdditiveRepository>();
            services.AddTransient<IRepository<Eadditives>, EAdditiveRepository>();
            services.AddSingleton<IService<Products>, ProductService>();
            services.AddTransient<IService<Products>, ProductService>();
            services.AddSingleton<IService<Eadditives>, EAdditiveService>();
            services.AddTransient<IService<Eadditives>, EAdditiveService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Test API",
                    Description = "ASP.NET Core Web API"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });
        }
    }
}
