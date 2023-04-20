namespace WinFormsApp;

public static class Program
{
    #region ��������� ��������� ������������

    private static IServiceProvider? _services;
    /// <summary> ������-��������� </summary>
    public static IServiceProvider Services => _services ??= GetServices().BuildServiceProvider();
    private static IServiceCollection GetServices()
    {
        var services = new ServiceCollection();
        InitServices(services);
        return services;
    }
    private static void InitServices(IServiceCollection services)
    {
        services.AddScoped<MainForm>();
        
        services.AddScoped<ICounter, Counter>();

    }

    #endregion

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        var form = Services.GetRequiredService<MainForm>();
        Application.Run(form);
    }
}
