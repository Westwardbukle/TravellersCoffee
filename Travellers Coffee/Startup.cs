using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Travellers_Coffee.Data;
using Travellers_Coffee.Data.interfaces;
using Travellers_Coffee.Data.mocks;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using Microsoft.EntityFrameworkCore;
using Travellers_Coffee.Data.Models;
using Travellers_Coffee.Data.Repository;

namespace Travellers_Coffee
{
    public class Startup
    {
        
        private IConfigurationRoot _confString;

        public Startup(IHostEnvironment hostEnv)
        {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath)
                .AddJsonFile("dbsettings.json").Build();
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContent>(options =>
                options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IAllProducts, CoffeeRepository>();
            services.AddTransient<ICoffeCategory, CategoryRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShopCart.GetCart(sp));
            
            services.AddMvc();

            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();
            
            
            using (var scope=app.ApplicationServices.CreateScope())
            {
                AppDbContent dbContent = scope.ServiceProvider.GetRequiredService<AppDbContent>();
                DbObjects.Initial(dbContent);
            }
        }
    }
}