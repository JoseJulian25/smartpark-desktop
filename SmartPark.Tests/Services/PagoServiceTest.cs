using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class PagoServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket1 = CreateTicket(espacio.Id, 1);
            var ticket2 = CreateTicket(espacio.Id, 1);
            context.Tickets.AddRange(ticket1, ticket2);
            await context.SaveChangesAsync();

            var service = new PagoService(context);
            var pago = new Pago
            {
                HoraPago = DateTime.UtcNow,
                MetodoPago = "Efectivo",
                Monto = 100m,
                MontoRecibido = 100m,
                TicketId = ticket1.Id,
                Ticket = ticket1
            };

            var resultado = await service.Guardar(pago);

            Assert.True(resultado);
            Assert.Equal(1, await context.Pagos.CountAsync());
        }

        [Fact]
        public async Task Buscar_CuandoExistePago_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket1 = CreateTicket(espacio.Id, 1);
            var ticket2 = CreateTicket(espacio.Id, 1);
            context.Tickets.AddRange(ticket1, ticket2);
            await context.SaveChangesAsync();

            var pago = new Pago
            {
                Id = 1,
                HoraPago = DateTime.UtcNow,
                MetodoPago = "Tarjeta",
                Monto = 150m,
                MontoRecibido = 200m,
                TicketId = ticket1.Id,
                Ticket = ticket1
            };

            context.Pagos.Add(pago);
            await context.SaveChangesAsync();

            var service = new PagoService(context);
            var encontrado = await service.Buscar(1);

            Assert.NotNull(encontrado);
            Assert.Equal(150m, encontrado!.Monto);
        }

        [Fact]
        public async Task Eliminar_CuandoExistePago_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket1 = CreateTicket(espacio.Id, 1);
            var ticket2 = CreateTicket(espacio.Id, 1);
            context.Tickets.AddRange(ticket1, ticket2);
            await context.SaveChangesAsync();

            var pago = new Pago
            {
                Id = 1,
                HoraPago = DateTime.UtcNow,
                MetodoPago = "Efectivo",
                Monto = 80m,
                MontoRecibido = 100m,
                TicketId = ticket1.Id,
                Ticket = ticket1
            };

            context.Pagos.Add(pago);
            await context.SaveChangesAsync();

            var service = new PagoService(context);
            var resultado = await service.Eliminar(1);

            Assert.True(resultado);
            Assert.Equal(0, await context.Pagos.CountAsync());
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket1 = CreateTicket(espacio.Id, 1);
            var ticket2 = CreateTicket(espacio.Id, 1);
            context.Tickets.AddRange(ticket1, ticket2);
            await context.SaveChangesAsync();

            context.Pagos.AddRange(
                new Pago
                {
                    Id = 1,
                    HoraPago = DateTime.UtcNow,
                    MetodoPago = "Efectivo",
                    Monto = 100m,
                    MontoRecibido = 100m,
                    TicketId = ticket1.Id,
                    Ticket = ticket1
                },
                new Pago
                {
                    Id = 2,
                    HoraPago = DateTime.UtcNow,
                    MetodoPago = "Tarjeta",
                    Monto = 200m,
                    MontoRecibido = 200m,
                    TicketId = ticket2.Id,
                    Ticket = ticket2
                });

            await context.SaveChangesAsync();

            var service = new PagoService(context);
            var resultados = await service.GetList(p => p.MetodoPago == "Efectivo");

            Assert.Single(resultados);
            Assert.Equal(100m, resultados[0].Monto);
        }

        [Fact]
        public async Task RegistrarCobro_CuandoTicketExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, 1);
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new PagoService(context);
            var pago = new Pago
            {
                MetodoPago = "Efectivo",
                Monto = 150m,
                MontoRecibido = 200m
            };

            var resultado = await service.RegistrarCobro(pago, ticket.Id);

            Assert.True(resultado);

            var ticketActualizado = await context.Tickets
                .Include(t => t.Espacio)
                .FirstAsync(t => t.Id == ticket.Id);

            Assert.Equal(150m, ticketActualizado.MontoTotal);
            Assert.Equal(2, ticketActualizado.EstadoId);
            Assert.Equal(1, ticketActualizado.Espacio.EstadoId);
            Assert.Equal(ticket.Id, pago.TicketId);
        }

        [Fact]
        public async Task Guardar_CuandoEntidadEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var resultado = await service.Guardar(null!);

            Assert.False(resultado);
        }

        [Fact]
        public async Task Guardar_CuandoExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(2);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, 1);
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var pago = new Pago
            {
                HoraPago = DateTime.UtcNow,
                MetodoPago = "Efectivo",
                Monto = 100m,
                MontoRecibido = 100m,
                TicketId = ticket.Id
            };
            context.Pagos.Add(pago);
            await context.SaveChangesAsync();

            var service = new PagoService(context);
            
            pago.MetodoPago = "Tarjeta";
            var resultado = await service.Guardar(pago);

            Assert.True(resultado);
            var modificado = await context.Pagos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == pago.Id);
            Assert.Equal("Tarjeta", modificado!.MetodoPago);
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var encontrado = await service.Buscar(999L);

            Assert.Null(encontrado);
        }

        [Fact]
        public async Task Eliminar_CuandoNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var resultado = await service.Eliminar(999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarCobro_CuandoPagoEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var resultado = await service.RegistrarCobro(null!, 1);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarCobro_CuandoTicketIdInvalido_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var pago = new Pago { MetodoPago = "Efectivo", Monto = 100m, MontoRecibido = 100m };
            var resultado = await service.RegistrarCobro(pago, 0);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarCobro_CuandoTicketNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new PagoService(context);

            var pago = new Pago { MetodoPago = "Efectivo", Monto = 100m, MontoRecibido = 100m };
            var resultado = await service.RegistrarCobro(pago, 999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task RegistrarCobro_CuandoTicketNoTieneEspacio_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            
            var ticket = new Ticket
            {
                CodigoTicket = "T-123",
                FechaCreacion = DateTime.UtcNow,
                HoraEntrada = DateTime.UtcNow,
                Placa = "B0002",
                EstadoId = 1
            };
            context.Tickets.Add(ticket);
            await context.SaveChangesAsync();

            var service = new PagoService(context);

            var pago = new Pago { MetodoPago = "Efectivo", Monto = 100m, MontoRecibido = 100m };
            var resultado = await service.RegistrarCobro(pago, ticket.Id);

            Assert.False(resultado);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
        {
            context.EstadosEspacios.AddRange(
                new EstadosEspacio { Id = 1, Nombre = "Disponible" },
                new EstadosEspacio { Id = 2, Nombre = "Ocupado" });

            context.EstadosTickets.AddRange(
                new EstadosTicket { Id = 1, Nombre = "Activo" },
                new EstadosTicket { Id = 2, Nombre = "Cerrado" });

            context.TiposVehiculos.Add(new TiposVehiculo { Id = 1, Nombre = "Carro" });

            await context.SaveChangesAsync();
        }

        private static Espacio CreateEspacio(int estadoId)
        {
            return new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-200",
                EstadoId = estadoId,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };
        }

        private static Ticket CreateTicket(long espacioId, int estadoId)
        {
            return new Ticket
            {
                CodigoTicket = $"T-{Guid.NewGuid():N}",
                FechaCreacion = DateTime.UtcNow,
                HoraEntrada = DateTime.UtcNow,
                Placa = "B0002",
                EspacioId = espacioId,
                EstadoId = estadoId
            };
        }
    }
}
