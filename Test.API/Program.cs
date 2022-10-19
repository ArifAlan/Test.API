using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Test.Modules.Mappers;
using Test.Modules;
using Test.Data;

namespace Test.API
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver()
                {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                };
            });

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen(opt =>
            {
                

            });

            builder.Services.IocDataRepositoryInstall();

            builder.Services.IocModulesInstall();

            builder.Services.IocMapperInstall();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseSwagger();

            app.UseSwaggerUI();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}