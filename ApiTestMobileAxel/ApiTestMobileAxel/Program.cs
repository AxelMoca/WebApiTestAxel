using ApiTestMobileAxel;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowIonicApp",
        builder =>
        {
            builder.WithOrigins("http://localhost:8100") //Esta linea permite que se deje conectar desde esa ip
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Agregar servicios al contenedor.
builder.Services.AddControllers();
builder.Services.AddSingleton<UserService>();

// Agregar servicios de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

var app = builder.Build();

// esta linea es para evitar el error de cors
app.UseCors("AllowIonicApp");

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    // Habilitar swagger en el entorno de desarrollo y evita el error de que no salga nada al correr la api
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();