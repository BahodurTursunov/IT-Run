using System.Text.Json.Serialization;
using FabricSystem.Infrastucture;
using FabricSystem.Repositories;
using FabricSystem.Servises;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace 
    FabricSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<FabricContext>(con => con.UseSqlServer("server=BAKHACOMP;integrated security=True; database=Fabric;TrustServerCertificate=true;"));/*.LogTo(Console.Write, LogLevel.Information).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));*/


            //string connection = builder.Configuration.GetConnectionString("DefaultConnection");

            // обновлением контекст ApplicationContext в качестве сервиса в приложение
            //builder.Services.AddDbContext<FabricContext>(options => options.UseSqlServer(connection));



            // Add services to the container.
            builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));

            var app = builder.Build();

           // app.MapGet("/", (FabricContext db) => db.Product.ToList());


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }


    }
}

