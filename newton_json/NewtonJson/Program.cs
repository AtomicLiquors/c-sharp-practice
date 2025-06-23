var builder = WebApplication.CreateBuilder(args);

// OpenAPI setup
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Register endpoint mappings
app.MapIndexEndpoint();
app.MapWeatherForecastEndpoint();
app.MapPersonEndpoint();


app.Run();