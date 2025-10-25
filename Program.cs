using Microsoft.EntityFrameworkCore;
using WebApplication3.Ecommerce.Infrastructure.Persistence;
using WebApplication3.Ecommerce.Domain.Ports;
using WebApplication3.Ecommerce.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<ECommerceDbContext>(options =>
    options.UseSqlite("Data Source=ecommerce.db")); // ou UseSqlServer(connectionString)

// Repositório e serviço
builder.Services.AddScoped<IProductRepository, EFProductRepository>();
builder.Services.AddScoped<ProductService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
