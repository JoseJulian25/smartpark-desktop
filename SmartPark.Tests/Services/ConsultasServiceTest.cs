using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class ConsultasServiceTest
    {
        [Fact]
        public async Task GetHistorialEntradasSalidas_FiltraPorFechaPlacaTicket()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio();
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            context.Tickets.AddRange(
                new Ticket
                {
                    CodigoTicket = "T-001",
                    Placa = "ABC123",
                    HoraEntrada = DateTime.Today.AddHours(8),
                    EspacioId = espacio.Id,
                    Estado = "ACTIVO"
                },
                new Ticket
                {
                    CodigoTicket = "T-002",
                    Placa = "XYZ999",
                    HoraEntrada = DateTime.Today.AddHours(10),
                    EspacioId = espacio.Id,
                    Estado = "ACTIVO"
                },
                new Ticket
                {
                    CodigoTicket = "T-003",
                    Placa = "ABC123",
                    HoraEntrada = DateTime.Today.AddDays(-2),
                    EspacioId = espacio.Id,
                    Estado = "ACTIVO"
                });

            await context.SaveChangesAsync();

            var service = new ConsultasService(context);
            var resultados = await service.GetHistorialEntradasSalidas(
                DateTime.Today,
                DateTime.Today,
                "ABC",
                "T-001");

            Assert.Single(resultados);
            Assert.Equal("T-001", resultados[0].CodigoTicket);
        }

        [Fact]
        public async Task GetPagos_FiltraPorMetodoTicketYFecha()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = CreateEspacio();
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var ticket1 = new Ticket
            {
                CodigoTicket = "T-100",
                Placa = "AAA111",
                HoraEntrada = DateTime.Today.AddHours(8),
                EspacioId = espacio.Id,
                Estado = "CERRADO"
            };

            var ticket2 = new Ticket
            {
                CodigoTicket = "T-200",
                Placa = "BBB222",
                HoraEntrada = DateTime.Today.AddHours(9),
                EspacioId = espacio.Id,
                Estado = "CERRADO"
            };

            var ticket3 = new Ticket
            {
                CodigoTicket = "T-300",
                Placa = "CCC333",
                HoraEntrada = DateTime.Today.AddDays(-2).AddHours(7),
                EspacioId = espacio.Id,
                Estado = "CERRADO"
            };

            context.Tickets.AddRange(ticket1, ticket2, ticket3);
            await context.SaveChangesAsync();

            context.Pagos.AddRange(
                new Pago
                {
                    HoraPago = DateTime.Today.AddHours(9),
                    MetodoPago = "Efectivo",
                    Monto = 50m,
                    MontoRecibido = 50m,
                    TicketId = ticket1.Id
                },
                new Pago
                {
                    HoraPago = DateTime.Today.AddHours(10),
                    MetodoPago = "Tarjeta",
                    Monto = 75m,
                    MontoRecibido = 75m,
                    TicketId = ticket2.Id
                },
                new Pago
                {
                    HoraPago = DateTime.Today.AddDays(-2),
                    MetodoPago = "Efectivo",
                    Monto = 60m,
                    MontoRecibido = 60m,
                    TicketId = ticket3.Id
                });

            await context.SaveChangesAsync();

            var service = new ConsultasService(context);
            var resultados = await service.GetPagos(
                DateTime.Today,
                DateTime.Today,
                "Efectivo",
                "T-100");

            Assert.Single(resultados);
            Assert.Equal("Efectivo", resultados[0].MetodoPago);
            Assert.Equal(ticket1.Id, resultados[0].TicketId);
        }

        [Fact]
        public void BuildTiempo_CuandoSalidaEsNull_RetornaVacio()
        {
            var resultado = ConsultasService.BuildTiempo(DateTime.Today, null);

            Assert.Equal(string.Empty, resultado);
        }

        [Fact]
        public void BuildTiempo_CuandoSalidaEsMenor_RetornaVacio()
        {
            var entrada = DateTime.Today.AddHours(10);
            var salida = DateTime.Today.AddHours(9);

            var resultado = ConsultasService.BuildTiempo(entrada, salida);

            Assert.Equal(string.Empty, resultado);
        }

        [Fact]
        public void BuildTiempo_CuandoSalidaValida_RetornaFormato()
        {
            var entrada = DateTime.Today.AddHours(8).AddMinutes(10);
            var salida = DateTime.Today.AddHours(9).AddMinutes(15);

            var resultado = ConsultasService.BuildTiempo(entrada, salida);

            Assert.Equal("1h 5m", resultado);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
        {
            context.TiposVehiculos.Add(new TiposVehiculo { Id = 1, Nombre = "Carro" });
            await context.SaveChangesAsync();
        }

        private static Espacio CreateEspacio()
        {
            return new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-500",
                Estado = "LIBRE",
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };
        }
    }
}
