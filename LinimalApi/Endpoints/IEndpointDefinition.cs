using Microsoft.AspNetCore.Routing;

namespace LinimalApi.Endpoints;

public interface IEndpointDefinition
{
    void Map(IEndpointRouteBuilder routes);
}