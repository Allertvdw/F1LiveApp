using F1LiveApp.Business.Interfaces.Repositories;
using F1LiveApp.Business.Interfaces.Services;
using F1LiveApp.Business.Services;
using F1LiveApp.Data.Data;
using F1LiveApp.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Internal;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<DataContext>(options =>
{
	options.UseMySql(
		connectionString,
		new MySqlServerVersion(new Version(8, 3, 0)),
		MySqlOptions => MySqlOptions.MigrationsAssembly("F1LiveApp.Data"));
});

// Add services to the container.
builder.Services.AddScoped<DataContext>();

builder.Services.AddScoped<IDriverService, DriverService>();
builder.Services.AddScoped<IDriverRepository, DriverRepository>();

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
