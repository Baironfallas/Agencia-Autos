using DataAccess.Layer.FileRepositories;
using Microsoft.OpenApi.Models;
using NLayer.Architecture.Bussines.Services;
using NLayer.Architecture.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AgenciaAutos.API", Version = "v1" });
});

builder.Services.AddTransient<IReporteAgenciaServices, ReporteAgenciaServices>();
builder.Services.AddTransient<IFileRepository, FileRepository>();
builder.Services.AddTransient<IReporteAgenciaRepository, ReporteAgenciaRepository>();

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



//var builder = WebApplication.CreateBuilder(args); Esta instancia permite configurar y construir una aplicación web.
//builder.services.addcontroller();configurara la aplicacion para que pueda responder ya hacer solicitudes hhtp
//builder.Services.AddEndpointsApiExplorer(); me permite utilizar swagger 
//builder.Services.AddSwaggerGen(); su funcion es activar el swagger y
//Su función principal es configurar y generar la documentación basada en OpenAPI 
//La configuración dentro de AddSwaggerGen() incluye detalles como el título de tu API, la versión,
//descripciones adicionales, y otros metadatos que serán incluidos en la especificación OpenAPI generada.
//builder.Services.AddTransient<>aca lo que hago es agregar los servicios en el contenedor de dependencias
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
basicamente su funciones es habilitar el swagger  para probar la api en un navegador
 */
//app.UseHttpsRedirection(); lo que hace es mantener la misma ruta que esta usando el cliente
//app.UseAuthorization(); se usa para manejar y validar credenciales de los usuarios
//app.MapControllers();es crucial para establecer una estructura ordenada en la gestión de rutas dentro de una aplicación.