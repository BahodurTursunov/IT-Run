
using BankManagmentSys.Models;

namespace BankManagmentSys
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var worker = new Worker();
            var client = new Client();

            Person person1 = worker;
            Person person2 = client;
            person1.DoWork();
            worker.DoWork();
            client.DoWork();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


        }
    }
}
