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

            var espacio = CreateEspacio(1);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var ticket = CreateTicket(espacio.Id, 1);

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

            var espacio = CreateEspacio(1);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, 1);
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

            var espacio = CreateEspacio(1);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket = CreateTicket(espacio.Id, 1);
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

            var espacio = CreateEspacio(1);
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            context.Tickets.AddRange(
                CreateTicket(espacio.Id, 1),
                CreateTicket(espacio.Id, 2));

            await context.SaveChangesAsync();

            var service = new TicketService(context);
            var resultados = await service.GetList(t => t.EstadoId == 1);

            Assert.Single(resultados);
        }

        [Fact]
        public async Task RegistrarEntrada_CuandoEspacioDisponible_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio(1);
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
            Assert.Equal(2, espacioActualizado.EstadoId);
            Assert.Equal(espacio.Id, ticket.EspacioId);
            Assert.Equal(1, ticket.EstadoId);
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
                CodigoEspacio = "E-100",
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
                Placa = "A0001",
                EspacioId = espacioId,
                EstadoId = estadoId
            };
        }
    }
}
