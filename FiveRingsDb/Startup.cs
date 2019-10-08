using System.Text.Json.Serialization;
using FiveRingsDb.Models;
using FiveRingsDb.Repositories;
using FiveRingsDb.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FiveRingsDb
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //services.AddMvc()
            //    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
            //    .AddJsonOptions(options =>
            //    {
            //        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            //        options.JsonSerializerOptions.IgnoreNullValues = true;
            //    });

            services.AddEntityFrameworkNpgsql()
                .AddDbContext<FiveRingsDbContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("FiveRingsDb")));

            services.AddScoped<ICardsRepository, CardsRepository>();
            services.AddSingleton<IFileReader, FileReader>();
        }

        // This method gets called by the runtime. Use this method to  the HTTP request pipeline.
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
