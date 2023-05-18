using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Forms;
using WinFormsApp.Infra.Abstracts;
using WinFormsApp.Infra.Presenters;

namespace WinFormsApp.Configs;

public static class RegisterExtensions
{
    public static IServiceCollection ProgramRegister(this IServiceCollection services)
    {
        services.AddScoped<MainForm>();
        services.AddScoped<IMainFormView>(_ => 
            Program.Services.GetRequiredService<MainForm>());
        services.AddScoped<MainFormPresenter>();
        services.AddSingleton(_ => 
            new ApplicationContext(Program.Services.GetRequiredService<MainForm>()));

        return services;
    }
}