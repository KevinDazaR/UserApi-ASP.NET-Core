using Microsoft.EntityFrameworkCore;
using UserApi.Infraestructure.Data;
using UserApi.Models;
using UserApi.Services.Interface;
using UserApi.Services.Repository;

var builder = WebApplication.CreateBuilder(args);


// Configurar EF Core con SQL Server 
builder.Services.AddDbContext<BaseContext>(options => options.UseMySql(
    builder.Configuration.GetConnectionString("DbConnection"),
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql"))
);

// Registrar servicios y repositorios
builder.Services.AddScoped<IUserRepository, UserRepository>();



// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar servicios
builder.Services.AddControllers(); // Agregar servicios de controladores

// Crear la aplicación
var app = builder.Build();


// Configurar el middleware de la aplicación
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Muestra errores detallados en desarrollo
}

app.UseRouting(); // Habilitar el enrutamiento

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();    

app.Run();
