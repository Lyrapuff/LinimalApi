using System.Reflection;
using LinimalApi.Endpoints;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LinimalApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static void UseEndpoints(this WebApplication app)
    {
        foreach (var endpointDefinition in app.Services.GetServices<IEndpointDefinition>())
        {
            endpointDefinition.Map(app);
        }
    }

    public static void AddEndpoints(this IServiceCollection services)
    {
        var endpoints = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.GetInterface(nameof(IEndpointDefinition)) is { });

        foreach (var endpoint in endpoints)
        {
            services.AddSingleton(typeof(IEndpointDefinition),endpoint);
        }
    }
}