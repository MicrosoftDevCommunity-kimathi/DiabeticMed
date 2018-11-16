using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiabeticmedApi.Data;
using DiabeticmedApi.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DiabeticmedApi
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
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DiabeticMedDbcontext>()
                .AddDefaultTokenProviders();
            services.AddMvc();
            services.AddDbContext<DiabeticMedDbcontext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(  routes=>
                    routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=get}/{id?}"));
       
            SeedData.EnsurePatientPopulated(app);
        }                   
    }
}
