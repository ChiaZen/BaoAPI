using BaoProject.Domain;
using BaoProject.Domain.Interfaces;
using BaoProject.Domain.Services;
using BaoProject.Infrastructure.Commands;
using BaoProject.Infrastructure.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddScoped<IBaoService, BaoService>();
builder.Services.AddScoped<IBaoFillingService, BaoFillingService>();

//Queries
builder.Services.AddScoped<IBaoQuery, BaoQuery>();
builder.Services.AddScoped<IBaoByIdQuery, BaoByIdQuery>();
builder.Services.AddScoped<IBaoSearchQuery, BaoSearchQuery>();

//Commands
builder.Services.AddScoped<IBaoCreateCommand, BaoCreateCommand>();
builder.Services.AddScoped<IBaoFillingCreateCommand , BaoFillingCreateCommand>();

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
