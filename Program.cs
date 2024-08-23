var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Map controllers here
app.MapControllers();

// Configure the HTTP request pipeline.
// Serve Swagger in all environments (Development, Staging, Production, etc.)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty; // Serve Swagger at the root of the application
});

app.UseHttpsRedirection();

app.Run();
