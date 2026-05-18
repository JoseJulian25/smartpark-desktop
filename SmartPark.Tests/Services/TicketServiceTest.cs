using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class TicketServiceTest
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

            var service = new TicketService(context);
            var ticket = CreateTicket(espacio.Id, "ACTIVO");

            var resultado = await service.Guardar(ticket);

            Assert.True(resultado);
            Assert.Equal(1, await context.Tickets.CountAsync());
        }

        [Fact]
        public async Task Buscar_CuandoExisteTicket_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var encontrado = await service.Buscar(ticket.Id);

            Assert.NotNull(encontrado);
            Assert.Equal(ticket.CodigoTicket, encontrado!.CodigoTicket);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteTicket_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultado = await service.Eliminar(ticket.Id);

            Assert.True(resultado);
            Assert.Equal(0, await context.Tickets.CountAsync());
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

            context.Tickets.AddRange(
                CreateTicket(espacio.Id, "ACTIVO"),
                CreateTicket(espacio.Id, "CERRADO"));

            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultados = await service.GetList(t => t.Estado == "ACTIVO");

            Assert.Single(resultados);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoEspacioDisponible_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("LIBRE");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var ticket = new Ticket
            {
                CodigoTicket = "",
                Placa = "A0001"
            };

            var resultado = await service.RegistrarEntrada(ticket, espacio.Id);

            Assert.True(resultado);

            var espacioActualizado = await context.Espacios.FirstAsync(e => e.Id == espacio.Id);
            Assert.Equal("OCUPADO", espacioActualizado.Estado);
            Assert.Equal(espacio.Id, ticket.EspacioId);
            Assert.Equal("ACTIVO", ticket.Estado);
        }

        [Fact]
        public async Task Guardar_CuandoEntidadEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

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

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            
            ticket.Placa = "MODIFICADO";
            var resultado = await service.Guardar(ticket);

            Assert.True(resultado);
            var modificado = await context.Tickets.AsNoTracking().FirstOrDefaultAsync(t => t.Id == ticket.Id);
            Assert.Equal("MODIFICADO", modificado!.Placa);
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

            var encontrado = await service.Buscar(999L);

            Assert.Null(encontrado);
        }

        [Fact]
        public async Task Eliminar_CuandoNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

            var resultado = await service.Eliminar(999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoTicketEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

            var resultado = await service.RegistrarEntrada(null!, 1);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoEspacioIdInvalido_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

            var ticket = new Ticket { Placa = "A0001" };
            var resultado = await service.RegistrarEntrada(ticket, 0);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoEspacioNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new TicketService(context);

            var ticket = new Ticket { Placa = "A0001" };
            var resultado = await service.RegistrarEntrada(ticket, 999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoEspacioNoEstaDisponible_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("OCUPADO");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new TicketService(context);

            var ticket = new Ticket { Placa = "A0001" };
            var resultado = await service.RegistrarEntrada(ticket, espacio.Id);

            Assert.False(resultado);
        }

        [Fact]
        public async Task AnularTicket_CuandoNoTienePago_AnulaYLiberaEspacio()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("OCUPADO");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultado = await service.AnularTicket(ticket.Id);

            Assert.True(resultado);
            var actualizado = await context.Tickets.AsNoTracking().FirstOrDefaultAsync(t => t.Id == ticket.Id);
            var espacioActualizado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacio.Id);
            Assert.True(actualizado!.Anulado);
            Assert.Equal("ANULADO", actualizado.Estado);
            Assert.Equal("LIBRE", espacioActualizado!.Estado);
        }

        [Fact]
        public async Task AnularTicket_CuandoTienePago_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("OCUPADO");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            context.Pagos.Add(new Pago
            {
                TicketId = ticket.Id,
                Monto = 100m,
                MetodoPago = "Efectivo",
                MontoRecibido = 100m,
                HoraPago = DateTime.UtcNow
            });
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultado = await service.AnularTicket(ticket.Id);

            Assert.False(resultado);
        }

        [Fact]
        public async Task AnularTicket_CuandoEstaAnulado_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("OCUPADO");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ANULADO");
            ticket.Anulado = true;
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultado = await service.AnularTicket(ticket.Id);

            Assert.False(resultado);
        }

        [Fact]
        public async Task AnularTicket_CuandoTieneReserva_ReservaVuelvePendiente()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio("OCUPADO");
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var reserva = new Reserva
            {
                ClienteEmail = "demo@demo.com",
                ClienteNombreCompleto = "Demo",
                ClienteTelefono = "8090000000",
                CodigoReserva = "R-100",
                FechaCreacion = DateTime.UtcNow,
                HoraInicio = DateTime.Today.AddHours(9),
                Placa = "A0001",
                EspacioId = espacio.Id,
                TipoVehiculoId = 1,
                Estado = "ACTIVA"
            };
            context.Reservas.Add(reserva);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, "ACTIVO");
            ticket.ReservaId = reserva.Id;
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultado = await service.AnularTicket(ticket.Id);

            Assert.True(resultado);
            var reservaActualizada = await context.Reservas.AsNoTracking().FirstOrDefaultAsync(r => r.Id == reserva.Id);
            Assert.Equal("PENDIENTE", reservaActualizada!.Estado);
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
                CodigoEspacio = "E-100",
                Estado = estado,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };
        }

        private static Ticket CreateTicket(long espacioId, string estado)
        {
            return new Ticket
            {
                CodigoTicket = $"T-{Guid.NewGuid():N}",
                FechaCreacion = DateTime.UtcNow,
                HoraEntrada = DateTime.UtcNow,
                Placa = "A0001",
                EspacioId = espacioId,
                Estado = estado
            };
        }
    }
}
