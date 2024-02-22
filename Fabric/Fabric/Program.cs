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
            builder.Services.AddDbContext<FabricContext>(con => con.UseSqlServer("server=localhost;integrated security=True; database=Fabric;TrustServerCertificate=true;")
                .LogTo(Console.Write, LogLevel.Information)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            //builder.Services.AddDbContext<FabricContext>(con => con.UseSqlServer("server=localhost;integrated security=True; database=Fabric;TrustServerCertificate=true;")
            //.LogTo(Console.Write, LogLevel.Information));
            //string connectionString = "server=localhost;integrated security=True; database=Fabric;TrustServerCertificate=true;";
            //.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


            //string connection = builder.Configuration.GetConnectionString("DefaultConnection");

            // обновлением контекст ApplicationContext в качестве сервиса в приложение
            // builder.Services.AddDbContext<FabricContext>(options => options.UseSqlServer(connection));



            // Add services to the container.
            builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<FabricContext>();
                context.Database.EnsureCreated();

                //TODO -- NoTracking
                //var bank = context.Banks.First();
                //var oldName = bank.Name;
                //context.Attach(bank);
                //bank.Name = "Test";
                ////context.Update(bank);
                //context.SaveChanges();

                //bank.Name = oldName;
                //context.SaveChanges();

                //TODO - LazyLoadingProxies
                //var bank = context.Banks.First();
                //var name = bank.Name;
                //var branchs = bank.Branchs;


                //TODO: Lazy loading for spesific properties
                //var branch = context.Branchs.First();
                //var address = branch.Address;
                //var bank = branch.Bank;
                //var bank2 = branch.Bank;
            }

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

