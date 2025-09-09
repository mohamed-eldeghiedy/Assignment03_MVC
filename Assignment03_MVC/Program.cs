using Assignment.BLL.Services;
using Assignment.DAL.Context;
using Assignment.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assignment03_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IDepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IDepartmentRepository , DepartmentRepository>();
            //builder.Services.AddScoped<CompanyDbContext>();
            builder.Services.AddDbContext<CompanyDbContext>(options =>
            {   
                var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

                options.UseSqlServer(connectionString);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
