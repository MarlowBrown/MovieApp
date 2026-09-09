using Microsoft.EntityFrameworkCore;
using MovieApp.Models;

namespace MovieApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("MovieContext") ??
                               throw new InvalidOperationException("Connection string 'MovieContext' not found.");
        
        // Add services to the container.
        builder.Services.AddDbContext<MovieContext>(options => options.UseSqlite(connectionString));
        builder.Services.AddRouting(options =>
        {
            options.LowercaseUrls = true;
            options.AppendTrailingSlash = true;
        });
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        else
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseAuthorization();
        app.UseStaticFiles();
        
        app.MapStaticAssets();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}/{slug?}");
        });

        app.Run();
    }
}