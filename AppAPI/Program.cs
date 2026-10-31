using BLL;
using BLL.Services;
using DAL.EF;
using DAL.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ZeroHungerDbContext>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConn"));
});
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<CollectRequestRepo>();
builder.Services.AddScoped<EmployeeRepo>();
builder.Services.AddScoped<FoodItemRepo>();
builder.Services.AddScoped<RestaurantRepo>();

builder.Services.AddScoped<CollectRequestService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<FoodItemService>();
builder.Services.AddScoped<RestaurantService>();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
