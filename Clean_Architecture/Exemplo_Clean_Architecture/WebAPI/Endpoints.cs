using Application.Features;

namespace WebAPI;

public static class Endpoints
{
    public static void AdicinarEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/hello-world", (HelloWorld comando) => 
        {
            var result = comando.DizerOlaMundo();

            return result;

        }).Produces(200)
          .WithTags("Simples");
    }
}
