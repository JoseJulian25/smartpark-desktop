

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.Data;
using SmartPark.UI.Espacios;
using SmartPark.UI.Configuracion;
using SmartPark.UI.EntradasSalidas;
using SmartPark.UI.Main;

namespace SmartPark.UI;

static class Program
{
    public static ServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var services = new ServiceCollection();
        ConfigurerServices(services);

        ServiceProvider = services.BuildServiceProvider();
        Application.Run(ServiceProvider.GetRequiredService<MainForm>());
    }

    private static void ConfigurerServices(ServiceCollection services)
    {

        services.AddDbContext<SmartparkContext>(options =>
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=smartpark;Trusted_Connection=True;TrustServerCertificate=True", sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
            }));

        services.AddTransient<MainForm>();
        services.AddTransient<EspaciosList>();
        services.AddTransient<EspacioForm>();
        services.AddTransient<Services.EspaciosService>();
        services.AddTransient<ConfiguracionForm>();
        services.AddTransient<TarifaForm>();
        services.AddTransient<Services.EmpresaService>();
        services.AddTransient<Services.TarifaService>();
        services.AddTransient<Services.TicketService>();
        services.AddTransient<Services.PagoService>();
        services.AddTransient<EntradasSalidasForm>();
        services.AddTransient<CobrarSalidaForm>();
    }
}