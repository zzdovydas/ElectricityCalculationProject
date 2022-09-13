using ElectricityCalculationProject.Contexts;
using ElectricityCalculationProject.Interfaces;
using ElectricityCalculationProject.Repositories;
using ElectricityCalculationProject.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File($"Logs/{Assembly.GetExecutingAssembly().GetName().Name}.log")
    .WriteTo.Console()
    .CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IElectricityDataRetrievalService, ElectricityDataRetrievalService>();
builder.Services.AddScoped<IElectricityDataHandlerService, ElectricityDataHandlerService>();
builder.Services.AddScoped<IElectricityDataFilteringService, ElectricityDataFilteringService>();

builder.Services.AddScoped<IElectricityDataRepository, ElectricityDataRepository>();

builder.Services.AddDbContext<DataContext>();

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