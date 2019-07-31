using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TeaTimeSite.Data;
using TeaTimeSite.Data.Interfaces;
using TeaTimeSite.Data.Mocks;
using TeaTimeSite.Data.Repository;

namespace TeaTimeSite
{
    public class Startup
    {
        private IConfigurationRoot _confStr;
        public Startup(IHostingEnvironment hostInv)
        {
            _confStr = new ConfigurationBuilder().SetBasePath(hostInv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContent>(opt => opt.UseSqlServer(_confStr.GetConnectionString("DefaultConnection")));
            services.AddMvc();
            services.AddTransient<IGoods, GoodsRepository>();
            services.AddTransient<IGoodsCategory, CategoryRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            DBContent content;
            using (var scope = app.ApplicationServices.CreateScope())
            {
                content = scope.ServiceProvider.GetRequiredService<DBContent>();
                DBObject.Initial(content);
            }
        }
    }
}
