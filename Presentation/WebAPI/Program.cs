
using Application.Repositories.CompanyRepositories;
using Application.Repositories.OrderRepositories;
using Application.Repositories.ProductRepositories;
using Application.Repositories;
using Application.Services;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repositories.CompanyRepositories;
using Persistence.Repositories.OrderRepositories;
using Persistence.Repositories.ProductRepositories;
using Persistence.Repositories;
using Persistence.Services;
using System;
using MediatR;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<COManagementDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

            #region Dependency Injection
            builder.Services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            builder.Services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            builder.Services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            builder.Services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            builder.Services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();
            builder.Services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();

            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<ICompanyService, CompanyService>();
            builder.Services.AddScoped<IOrderService, OrderService>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            builder.Services.AddMediatR(typeof(Application.AssemblyReference).Assembly);

            builder.Services.AddControllers()
            .AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly);

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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}