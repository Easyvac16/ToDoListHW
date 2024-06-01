using Microsoft.EntityFrameworkCore;
using TestApi.Abstract;
using TestApi.Core;
using TestApi.Core.Abstract;
using TestApi.DAL;
using TestApi.DAL.Abstract;
using TestApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<MyContext>(options =>
                                         options.UseSqlServer(builder.Configuration
                                                                     .GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ISaveToDoList, SaveToDoList>();
builder.Services.AddScoped<IMyService, MyService>();
builder.Services.AddScoped<IMyRepository, Repository>();



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
