
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using System.Collections.Generic;
global using System.Linq;
global using System.Threading.Tasks;
global using APIMarketPlaceController.Models;
global using APIMarketPlaceController.Service;
global using APIMarketPlaceController.Data;
global using APIMarketPlaceController.Controllers;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy(name: "ApiMarketPlace", 
policy =>
{
    policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
}
));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IApiBoxService, ApiBoxService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

app.UseCors("ApiMarketPlace");

app.UseHttpsRedirection();


app.UseAuthorization();

app.MapControllers();

app.Run();
