using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartToDoListAPI.DataAccess.Concrete.EntityFramework.Contexts;

namespace SmartToDoListAPI
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
            services.AddCors(options =>
            {
                options.AddPolicy("AllowOrigin", builder => builder.WithOrigins("http://localhost:4200"));
            });

            //services.AddCors(options =>
            //{
            //    options.AddDefaultPolicy(
            //        builder =>
            //        {
            //            builder.WithOrigins("http://localhost:3000",
            //                                "http://192.168.1.40:1073")
            //                                      .AllowAnyHeader()
            //                                      .AllowAnyOrigin()
            //                                      .AllowCredentials()
            //                                      .AllowAnyMethod();
            //            //builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            //        });
            //});
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowOrigin", builder => builder.AllowAnyOrigin());

            //});



           // services.AddAutoMapper(typeof(Startup));
            services.AddControllers();
            //     services.AddDbContext<EfContext>(options =>
            //     services.AddDbContextPool<EfContext>(
            //options => options.UseMySQL(Configuration.GetConnectionString("DefaultConnection"))));

            services.AddDbContext<EfContext>();

            //services.AddDbContext<EfContext>(o => o.UseMySQL(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());

            //app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader());
            //app.UseCors();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
