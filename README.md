# Very lightweight endpoints for ASP.NET Core minimal api

### Ultraquick start

1. Define
```cs
public class ExampleEndpoint : IEndpointDefinition
{
    public void Map(IEndpointRouteBuilder routes)
    {
        routes.MapGet("hello", () => "Hello, meow!");
    }
}
```

2. Use
```cs
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpoints(Assembly.GetExecutingAssembly());

var app = builder.Build();

app.UseEndpoints();

app.Run();
```

And that's everything there is to it.

Meow.
