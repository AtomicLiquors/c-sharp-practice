
using System.Text;
using Newtonsoft.Json;

public static class PersonEndpoint
{
    public static IEndpointRouteBuilder MapPersonEndpoint(this IEndpointRouteBuilder app)
    {

        app.MapGet("/person", () =>
        {
            var person = new Person
            {
                Name = "Alice",
                Age = 25
            };

            var json = JsonConvert.SerializeObject(person, Formatting.Indented);
            return Results.Content(json, "application/json");
        })
        .WithName("GetPerson");


        app.MapPost("/person", async (HttpRequest request) =>
        {
            using var reader = new StreamReader(request.Body, Encoding.UTF8);
            var body = await reader.ReadToEndAsync();

            var person = JsonConvert.DeserializeObject<Person>(body);
            if (person is null)
                return Results.BadRequest("Invalid JSON.");

            var response = JsonConvert.SerializeObject(person, Formatting.Indented);
            return Results.Content(response, "application/json");
        });

        return app;
    }
}
