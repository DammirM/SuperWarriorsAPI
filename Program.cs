using Microsoft.EntityFrameworkCore;
using SuperWarriorsAPI.Context;
using SuperWarriorsAPI.Services;
using WarriorLibrary;

namespace SuperWarriorsAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //implementing repository pattern below:
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepo>();



            builder.Services.AddDbContext<WarriorContext>(options => options
            .UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

            var app = builder.Build();

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