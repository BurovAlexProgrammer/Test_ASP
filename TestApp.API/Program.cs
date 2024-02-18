using Microsoft.EntityFrameworkCore;
using TestApp.DAL.Postgres;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
builder.Services.AddControllers();
builder.Services.AddDbContext<PostgresDbContext>(options => 
    options.UseNpgsql(configuration.GetConnectionString(nameof(PostgresDbContext))));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
// app.UseAuthorization();
app.MapControllers();
app.Run();