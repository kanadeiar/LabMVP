using Microsoft.Extensions.DependencyInjection;
using WinFormsApp.Configs;
using WinFormsApp.Core.Configs;
using WinFormsApp.Forms;
using WinFormsApp.Infra.Configs;

namespace WinFormsApp
{
    internal static class Program
    {
        private static IServiceProvider? _services;
        /// <summary>
        /// Services of application
        /// </summary>
        public static IServiceProvider Services => _services ??= GetServices().BuildServiceProvider();
        private static IServiceCollection GetServices()
        {
            var services = new ServiceCollection();
            InitServices(services);
            return services;
        }
        private static void InitServices(IServiceCollection services)
        {
            services.ProgramRegister().InfraRegister().CoreRegister();

            //services.AddSingleton<IServiceProvider>(Program.Services);
        }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var form = Services.GetRequiredService<MainForm>();
            Application.Run(form);
        }
    }
}