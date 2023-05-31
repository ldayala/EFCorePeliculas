using EFCorePeliculas;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var cadenaConnection = builder.Configuration.GetConnectionString("DefaultConnection"); //optenemos la cadena de connection
//Adicionamos l builder un dbcontext para poder utilizar la inyection de dependencias.
builder.Services.AddDbContext<ApplicationDbContext>(opciones => 
            opciones.UseSqlServer(cadenaConnection,
            sqlServer=>sqlServer.UseNetTopologySuite()));  // activamos nettopolysuite

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
