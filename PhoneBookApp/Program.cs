using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Data;

namespace PhoneBookApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            _ = builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                _ = options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            WebApplication app = builder.Build();



            _ = app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
