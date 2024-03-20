using Microsoft.EntityFrameworkCore;
using TimeTableWebApp.Models;

namespace TimeTableWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<PRN221_PROJECTContext>(
                otp => otp.UseSqlServer(builder.Configuration.GetConnectionString("DBContext"))
                );
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapRazorPages();

            app.Run();
        }
    }
}