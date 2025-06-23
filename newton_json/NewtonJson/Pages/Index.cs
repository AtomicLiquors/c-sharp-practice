using Microsoft.AspNetCore.Builder;

public static class IndexEndpoint
{
    public static IEndpointRouteBuilder MapIndexEndpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", () => "2kooong2")
           .WithName("GetIndex");

        return app;
    }
}