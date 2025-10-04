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
builder.Services.AddScoped<IPredictionService, PredictionService>();

// Register HttpClient for prediction service
builder.Services.AddHttpClient();

// Configure CORS to allow requests from any origin
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

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

// Enable CORS
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
