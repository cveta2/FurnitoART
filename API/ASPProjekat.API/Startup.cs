using ASPProject.Application.Logging;
using ASPProject.Application.UseCases;
using ASPProject.Application.UseCases.Commands;
using ASPProject.Domain;
using ASPProject.Implementation;
using ASPProject.Implementation.Logging;
using ASPProject.Implementation.UseCases.Commands;
using ASPProject.Implementation.Validators;
using ASPProjekat.API.Core;
using ASPProjekat.API.Extensions;
using ASPProjekat.DataAccess;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPProjekat.API
{
    public class Startup
    {
        private string allowedOrigins = "allowedOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var settings = new AppSettings();

            Configuration.Bind(settings);

            services.AddCors(options =>
            {
                options.AddPolicy(allowedOrigins, builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
            services.AddSingleton(settings);
            services.AddJwt(settings);
            services.AddHttpContextAccessor();
            services.AddValidators();
            services.AddUseCases();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IExceptionLogger, EfExceptionLogging>();
            services.AddTransient<UseCaseHandler>();
            services.AddApplicationUser();
            services.AddTransient<ProjekatContext>();
            services.AddTransient<IUseCaseLogger, AuditLogInDatabase>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ASPProjekat.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASPProjekat.API v1"));
            }

            app.UseMiddleware<GlobalExceptionHandler>();
            app.UseRouting();
            app.UseCors(allowedOrigins);

            app.UseAuthentication();
            app.UseAuthorization();
      app.UseStaticFiles();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
