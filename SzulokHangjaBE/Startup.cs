using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using SzulokHangjaBE.Data;
using System.Text.Json.Serialization;
using SzulokHangjaBE.Models.Authentication;
using Microsoft.AspNetCore.Identity;

namespace SzulokHangjaBE
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
            services.AddCors();
            services.AddControllers();

            services.AddMvc().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });
            //*Later to move to SQL code snippet
            services.AddDbContext<SzulokHangjaBEContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SzulokHangjaBEContext")));

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<SzulokHangjaBEContext>();


            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "credentials";
                options.ExpireTimeSpan = TimeSpan.FromHours(24);
                options.Cookie.Domain = "localhost";
            });

            //services.AddDbContext<SzulokHangjaBEContext>(options =>
            //        options.UseInMemoryDatabase(Configuration.GetConnectionString("SzulokHangjaBEContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader().AllowCredentials());

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
