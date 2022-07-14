using src.Context;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using src.Repository.Interfaces;
using src.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

//Add Dependency Injection

builder.Services.AddScoped<IToolsRepository, ToolsRepository>();


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
