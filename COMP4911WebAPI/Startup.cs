using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP4911WebAPI.Helpers;
using COMP4911WebAPI.Models;
using COMP4911WebAPI.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Reflection;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;

namespace COMP4911WebAPI
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

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            services.AddMvc()
                .AddControllersAsServices() //allows calling controller actions from other controllers
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(
                    options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );


            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            //services.AddAuthentication(x =>
            //    {
            //        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    })
            //    .AddJwtBearer(x =>
            //    {
            //        x.RequireHttpsMetadata = false;
            //        x.SaveToken = true;
            //        x.TokenValidationParameters = new TokenValidationParameters
            //        {
            //            ValidateIssuerSigningKey = true,
            //            IssuerSigningKey = new SymmetricSecurityKey(key),
            //            ValidateIssuer = false,
            //            ValidateAudience = false
            //        };
            //    });

            services.AddAuthentication(option => {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options => {
                options.SaveToken = true;
                options.RequireHttpsMetadata = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.Secret))
                };
            });

            services.AddDbContext<ApplicationDbContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("ConnString")));
            services.AddScoped<IDataRepository<Employee>, EmployeeRepository>();
            services.AddScoped<IDataRepository<JobTitle>, JobTitleRepository>();
            services.AddScoped<IDataRepository<Credential>, CredentialRepository>();
            services.AddScoped<IDataRepository<Project>, ProjectRepository>();
            services.AddScoped<IDataRepository<EmployeeProjectAssignment>, EmployeeProjectAssignmentRepository>();
            services.AddScoped<IDataRepository<EmployeeWorkPackageAssignment>, EmployeeWorkPackageAssignmentRepository>();
            services.AddScoped<IDataRepository<Timesheet>, TimesheetRepository>();
            services.AddScoped<IDataRepository<TimesheetRow>, TimesheetRowRepository>();
            services.AddScoped<IDataRepository<WorkPackage>, WorkPackageRepository>();
            services.AddScoped<IDataRepository<LabourGrade>, LabourGradeRepository>();
            services.AddScoped<IDataRepository<WorkPackageReport>, WorkPackageReportRepository>();
            services.AddScoped<IDataRepository<WorkPackageReportDetails>, WorkPackageReportDetailsRepository>();
            services.AddScoped<IDataRepository<WorkPackageLabourGradeAssignment>, WorkPackageLabourGradeAssignmentRepository>();
            services.AddScoped<IDataRepository<EmployeeWorkPackageAssignment>, EmployeeWorkPackageAssignmentRepository> ();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "COMP 4911 Project - Web API", Version = "Version 1.0" });

                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //c.IncludeXmlComments(xmlPath);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                IdentityModelEventSource.ShowPII = true; //show error logs for authentication
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "COMP 4911 Project - Web API");
                c.RoutePrefix = string.Empty;
            });

            // global cors policy
            app.UseHttpsRedirection();
            app.UseCors("MyPolicy");
            app.UseAuthentication();
            app.UseMvc();  //this always after useAuthentication!


            //app.UseAuthorization();  //only in net 3.1
        }
    }
}
