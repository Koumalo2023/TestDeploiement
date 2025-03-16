using DotNetEnv;
using Microsoft.EntityFrameworkCore;


// Charger le fichier .env en premier
Env.Load();

var builder = WebApplication.CreateBuilder(args);

/// Charger les configurations depuis appsettings.json et appsettings.{Environment}.json
builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Configurer le contexte de base de données
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));



// Ajouter les services CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Utiliser les configurations chargées
var connectionString = app.Configuration.GetConnectionString("DefaultConnection");

// Utiliser la politique CORS
app.UseCors("AllowSpecificOrigin");
app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowSpecificOrigin");
    Console.WriteLine("Swagger is enabled for Development environment.");
}
else
{
    Console.WriteLine("Swagger is disabled for non-Development environments.");
}

app.Run();