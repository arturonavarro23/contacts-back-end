﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using WebAPI.Interfaces;
using WebAPI.BLL;
using WebAPI.DAL;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace WebAPI
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
                options.AddPolicy("RequestFromAll",
                                  policy => policy.AllowAnyOrigin()
                                  .AllowAnyHeader()
                                  .AllowAnyMethod());
            });
            services.AddMvc(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory("RequestFromAll"));
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<ContextAPI>();
            services.AddAutoMapper();
            services.AddScoped<IContactsService, ContactsService>();
            services.AddScoped<IContactsRepository, ContactRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
