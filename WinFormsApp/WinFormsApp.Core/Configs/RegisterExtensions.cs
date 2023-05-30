using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Core.Abstracts;
using WinFormsApp.Core.Models;

namespace WinFormsApp.Core.Configs;

public static class RegisterExtensions
{
    public static IServiceCollection CoreRegister(this IServiceCollection services)
    {
        services.AddScoped<ICounter, Counter>();

        return services;
    }

}