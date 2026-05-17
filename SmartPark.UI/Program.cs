

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartPark.Data;
using SmartPark.UI.Espacios;
using SmartPark.UI.Configuracion;
using SmartPark.UI.EntradasSalidas;
using SmartPark.UI.Main;
using SmartPark.UI.Usuarios;
using SmartPark.UI.Consultas;
using SmartPark.UI.Acceso;
using SmartPark.UI.Reservas;
using SmartPark.Data.Modelos;

namespace SmartPark.UI;

static class Program
{
    public static ServiceProvider ServiceProvider { get; private set; }
    public static Usuario? UsuarioActual { get; private set; }

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
        using var loginForm = ServiceProvider.GetRequiredService<LoginForm>();

        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            UsuarioActual = loginForm.UsuarioAutenticado;
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
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
        services.AddTransient<Services.ConsultasService>();
        services.AddTransient<Services.UsuarioService>();
        services.AddTransient<Services.ReservaService>();
        services.AddTransient<EntradasSalidasForm>();
        services.AddTransient<CobrarSalidaForm>();
        services.AddTransient<UsuariosForm>();
        services.AddTransient<NuevoUsuarioForm>();
        services.AddTransient<ConsultasForm>();
        services.AddTransient<ReservasForm>();
        services.AddTransient<NuevaReservaForm>();
        services.AddTransient<LoginForm>();
    }
}