using ClinicHistories.Infrastructure;
using ClinicHistories.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClinicHistories
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainMenu>());
        }
        
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddScoped<IPatientService, PatientService>();
                    services.AddTransient<MainMenu>();
                    services.AddDbContext<ClinicHistoryDbContext>(
                        options => options.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Initial Catalog=ClinicHistory;Trusted_Connection=True;"));
                });
        }
    }
}