using Microsoft.EntityFrameworkCore;
using sharks.Data;
using sharks.Repositories;
using sharks.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SharksDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register repositories and services
builder.Services.AddScoped<ISharkRepository, SharkRepository>();
builder.Services.AddScoped<ISharkService, SharkService>();
builder.Services.AddScoped<ISharkTrackingRepository, SharkTrackingRepository>();
builder.Services.AddScoped<ISharkTrackingService, SharkTrackingService>();

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
