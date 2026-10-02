using Microsoft.EntityFrameworkCore;
using Portfolio01.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dbcontext configuration for sql server connection string from appsettings.json
builder.Services.AddDbContext<PortfolioDbContext>(Options => 

    Options.UseSqlServer(builder.Configuration.GetConnectionString("PortfolioConnectionString")));
                
var app = builder.Build();

// Configure the HTTP request pipeline. // Middleware 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
