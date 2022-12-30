using AspNetCore.Identity.MongoDbCore.Models;
using CarPark.Business.Abstract;
using CarPark.Business.Concrete;
using CarPark.Core.Repository.Abstract;
using CarPark.Core.Settings;
using CarPark.DataAccess.Abstract;
using CarPark.DataAccess.Concrete;
using CarPark.DataAccess.Repository;
using CarPark.Entities.concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CarPark.User
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
            services.AddAutoMapper(typeof(Startup));
            services.AddAuthentication(option =>
            {
                option.DefaultScheme = IdentityConstants.ApplicationScheme;
                option.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            }).AddIdentityCookies(o =>
            {
                
            });

            services.AddIdentityCore<Personel>(option =>
            {

            })
            .AddRoles<MongoIdentityRole>()
            .AddMongoDbStores<Personel, MongoIdentityRole, Guid>(Configuration.GetSection("MongoConnection:ConnectionString").Value, Configuration.GetSection("MongoConnection:Database").Value)
            .AddSignInManager()
            .AddDefaultTokenProviders();


            services.ConfigureApplicationCookie(option =>
            {
                option.Cookie.HttpOnly = true;
                option.ExpireTimeSpan = TimeSpan.FromMinutes(5);//5dk kullan�lmazsa kapat

                option.LoginPath = "/Account/Login";
                option.SlidingExpiration = true;
            });


            services.AddScoped(typeof(IRepository<>), typeof(MongoRepositoryBase<>));
            services.AddScoped<IPersonelDataAccess, PersonelDataAccess>();
            services.AddScoped<IPersonelService, PersonelManager>();

            services.AddScoped<ICityDataAccess, CityDataAccess>();
            services.AddScoped<ICityService, CityManager>();


            services.AddControllersWithViews();
            
            services.Configure<MongoSettings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
