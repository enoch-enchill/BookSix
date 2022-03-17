using BookSix.Modules.People.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(assemblyName: "BookSix.Bootstrapper")]

namespace BookSix.Modules.People.Api;

internal static class PeopleModule
{
    public static IServiceCollection AddPeopleModule(this IServiceCollection services)
    {
        services.AddCore();

        return services;
    }

    public static IApplicationBuilder UsePeopleModule(this IApplicationBuilder app)
    {
        return app;
    }
}