using System.Text.Json.Serialization;
using Fabric.Infrastructure;
using Fabric.Middlewares;
using Fabric.Repositories;
using Fabric.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
//using Swashbuckle.Swagger;

namespace Fabric
{
    public class Program
    {
        public const string AppKey = "TestKey";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<FabricContext>(con => con.UseSqlServer("server=localhost;integrated security=True; database=Fabric;TrustServerCertificate=true;")
                .LogTo(Console.Write, LogLevel.Information)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IWorkerService, WorkerService>();
            builder.Services.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddAutoMapper(typeof(Program));

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));


            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fabric Application APIs", Version = "v1" });

                var securityScheme = new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Description = "JWT Authorization header using the Bearer scheme.",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                };

                c.AddSecurityDefinition("Bearer", securityScheme);

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    { securityScheme, new List<string>() }  
                });
            });

            var app = builder.Build();
           
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseMiddleware<GlobalExceptionMiddleware>();
            app.UseMiddleware<AppicationKeyMiddleware>();
            app.UseMiddleware<EndPointListenerMiddleware>();

            app.UseHttpsRedirection();
            app.UseAuthorization();


            app.MapControllers();
            app.MapGet("MyMinAPI", (string name) => $"Hello {name}");

            app.Run();
        }
    }
}

