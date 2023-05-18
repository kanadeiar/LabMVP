using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Forms;

namespace WinFormsApp.Configs;

public static class RegisterExtensions
{
    public static IServiceCollection ProgramRegister(this IServiceCollection services)
    {
        services.AddSingleton<IServiceCollection>(services);
        services.AddScoped<MainForm>();

        return services;
    }
}