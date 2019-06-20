using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using UHype.Model;

namespace UHype
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            Env = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment Env { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDefaultIdentity<AppUsers>(x =>
            {
                x.Password.RequiredLength = 6;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = true;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
                x.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
            })
               .AddEntityFrameworkStores<AppDbContext>();

            services.AddDbContext<AppDbContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Angular's default header name for sending the XSRF token.
            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Env.IsProduction() ? "https://uhype.azurewebsites.net/" : "https://localhost:64955",
                    ValidAudience = Env.IsProduction() ? "https://uhype.azurewebsites.net/" : "https://localhost:64955",
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SxkeJZF776DgzfE!@"))
                };
            });

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            if (Env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (Env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
