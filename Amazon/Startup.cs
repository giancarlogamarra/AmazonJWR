using System.IO;
using Amazon.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace Amazon
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

         public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration["Data:AmazonStoreDB:ConnectionString"]));

            //services.AddTransient<IBookRepository, FakeBookRepository>();
            services.AddTransient<IBookRepository, EFBookRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes => {

                routes.MapRoute(
                name: null,
                template: "{category}/Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List" });

                routes.MapRoute(
                name: null,
                template: "Page{bookPage:int}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });

                routes.MapRoute(
                name: null,
                template: "{category}",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });

                routes.MapRoute(
                name: null,
                template: "",
                defaults: new { controller = "Book", action = "List", bookPage = 1 });

                routes.MapRoute(
                name: null,
                template: "{controller}/{action}/{id?}");

            });
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(),
                        @"node_modules")),
                RequestPath = new PathString("/vendor")
            });

            SeedData.EnsurePopulated(app);
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStaticFiles(new StaticFileOptions()
                {
                    FileProvider = new PhysicalFileProvider(
                        Path.Combine(Directory.GetCurrentDirectory(),
                        @"node_modules")),
                    RequestPath = new PathString("/vendor")
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });*/
        }
    }
}
