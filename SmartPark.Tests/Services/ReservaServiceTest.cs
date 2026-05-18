using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class ReservaServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));

            var resultado = await service.Guardar(reserva);

            Assert.True(resultado);
            Assert.Equal(1, await context.Reservas.CountAsync());
            var espacioActualizado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacio.Id);
            Assert.Equal("RESERVADO", espacioActualizado!.Estado);
        }

        [Fact]
        public async Task Guardar_CuandoFechaNoEsHoy_NoMarcaEspacioReservado()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddDays(1).AddHours(9));

            var resultado = await service.Guardar(reserva);

            Assert.True(resultado);
            var espacioActualizado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacio.Id);
            Assert.Equal("LIBRE", espacioActualizado!.Estado);
        }

        [Fact]
        public async Task Guardar_CuandoEntidadEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new ReservaService(context);

            var resultado = await service.Guardar(null!);

            Assert.False(resultado);
        }

        [Fact]
        public async Task Guardar_CuandoExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            reserva.Placa = "ABC999";
            var resultado = await service.Guardar(reserva);

            Assert.True(resultado);
            var actualizada = await context.Reservas.AsNoTracking().FirstOrDefaultAsync(r => r.Id == reserva.Id);
            Assert.Equal("ABC999", actualizada!.Placa);
        }

        [Fact]
        public async Task Buscar_CuandoExiste_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var encontrada = await service.Buscar(reserva.Id);

            Assert.NotNull(encontrada);
            Assert.Equal(reserva.CodigoReserva, encontrada!.CodigoReserva);
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new ReservaService(context);

            var encontrada = await service.Buscar(999L);

            Assert.Null(encontrada);
        }

        [Fact]
        public async Task Eliminar_CuandoExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.Eliminar(reserva.Id);

            Assert.True(resultado);
            Assert.Equal(0, await context.Reservas.CountAsync());
        }

        [Fact]
        public async Task Eliminar_CuandoNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new ReservaService(context);

            var resultado = await service.Eliminar(999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            context.Reservas.AddRange(
                CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9)),
                CreateReserva(espacio.Id, "CANCELADA", DateTime.Today.AddHours(10)));

            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultados = await service.GetList(r => r.Estado == "PENDIENTE");

            Assert.Single(resultados);
        }

        [Fact]
        public async Task GetReservas_FiltraPorFechaEstadoCliente()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            context.Reservas.AddRange(
                CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9), "Ana Perez"),
                CreateReserva(espacio.Id, "ACTIVA", DateTime.Today.AddHours(10), "Jose Diaz"),
                CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddDays(1).AddHours(9), "Ana Perez"));

            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultados = await service.GetReservas(DateTime.Today, "PENDIENTE", "Ana");

            Assert.Single(resultados);
            Assert.Equal("Ana Perez", resultados[0].ClienteNombreCompleto);
        }

        [Fact]
        public async Task GetEspaciosReservados_ExcluyeReservaIndicada()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio1 = CreateEspacio("LIBRE");
            var espacio2 = CreateEspacio("LIBRE");
            context.Espacios.AddRange(espacio1, espacio2);
            await context.SaveChangesAsync();

            var reserva1 = CreateReserva(espacio1.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            var reserva2 = CreateReserva(espacio2.Id, "ACTIVA", DateTime.Today.AddHours(10));
            context.Reservas.AddRange(reserva1, reserva2);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var reservados = await service.GetEspaciosReservados(DateTime.Today, reserva1.Id);

            Assert.Single(reservados);
            Assert.Equal(espacio2.Id, reservados[0]);
        }

        [Fact]
        public async Task ConfirmarReserva_CuandoReservaPendiente_ActivaYGeneraTicket()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.ConfirmarReserva(reserva.Id);

            Assert.True(resultado);
            var reservaActualizada = await context.Reservas.AsNoTracking().FirstOrDefaultAsync(r => r.Id == reserva.Id);
            Assert.Equal("ACTIVA", reservaActualizada!.Estado);
            Assert.Equal(1, await context.Tickets.CountAsync());
        }

        [Fact]
        public async Task ConfirmarReserva_CuandoNoEsPendiente_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "ACTIVA", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.ConfirmarReserva(reserva.Id);

            Assert.False(resultado);
        }

        [Fact]
        public async Task CancelarReserva_CuandoPendiente_CambiaEstadoYMotivo()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.CancelarReserva(reserva.Id, "Cliente cancela", 1);

            Assert.True(resultado);
            var actualizada = await context.Reservas.AsNoTracking().FirstOrDefaultAsync(r => r.Id == reserva.Id);
            Assert.Equal("CANCELADA", actualizada!.Estado);
            Assert.Equal("Cliente cancela", actualizada.MotivoCancelacion);
            Assert.Equal(1, actualizada.CanceladoPor);
        }

        [Fact]
        public async Task CancelarReserva_CuandoNoPendiente_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "ACTIVA", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.CancelarReserva(reserva.Id, "No procede", 1);

            Assert.False(resultado);
        }

        [Fact]
        public async Task CancelarReserva_CuandoMotivoVacio_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = CreateReserva(espacio.Id, "PENDIENTE", DateTime.Today.AddHours(9));
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var service = new ReservaService(context);
            var resultado = await service.CancelarReserva(reserva.Id, " ");

            Assert.False(resultado);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
        {
            context.TiposVehiculos.Add(new TiposVehiculo { Id = 1, Nombre = "Carro" });
            await context.SaveChangesAsync();
        }

        private static Espacio CreateEspacio(string estado)
        {
            return new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-300",
                Estado = estado,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };
        }

        private static Reserva CreateReserva(long espacioId, string estado, DateTime horaInicio, string cliente = "Cliente")
        {
            return new Reserva
            {
                ClienteEmail = "cliente@demo.com",
                ClienteNombreCompleto = cliente,
                ClienteTelefono = "8090000000",
                CodigoReserva = $"R-{Guid.NewGuid():N}",
                FechaCreacion = DateTime.UtcNow,
                HoraInicio = horaInicio,
                Placa = "A0001",
                EspacioId = espacioId,
                TipoVehiculoId = 1,
                Estado = estado
            };
        }
    }
}
