using CQRS_ASP.NETCore6.Data;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using CQRS_ASP.NETCore6.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StudentContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDb"), opt =>
    {
        opt.MigrationsAssembly(Assembly.GetAssembly(typeof(StudentContext)).GetName().Name);
    });
});
builder.Services.CustomService();
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
