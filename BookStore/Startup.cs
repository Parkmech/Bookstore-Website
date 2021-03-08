//Parker Mecham, Section 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BookStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<BookStoreDBContext>(options =>
           {
           options.UseSqlite(Configuration.GetConnectionString("BookStoreConnection"));
           });

            services.AddScoped<iBookStoreRepository, EFBookStoreRepository>();

            services.AddRazorPages();
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

            app.UseAuthorization();


            //Sets the endpoints for the website so that the user can type a page number instead of a long string
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute("catpage",
                    "{category}/{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute("page",
                    "{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute("category",
                    "{category}",
                    new { Controller = "Home", action = "Index", page = 1 }
                    );

                endpoints.MapControllerRoute("page",
                    "Books/{page}",
                    new { Controller = "Home", action = "Index", page = 1 });

                endpoints.MapControllerRoute("pagination",
                    "{page}",
                    new { Controller = "Home", action = "Index", page = 1});

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
