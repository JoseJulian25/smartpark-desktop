using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class TarifaServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedTipoVehiculo(context);

            var service = new TarifaService(context);
            var tarifa = new Tarifa
            {
                MinutosFraccion = 30,
                MinutosMinimo = 60,
                MinutosTolerancia = 10,
                PrecioPorFraccion = 50m,
                TipoVehiculoId = 1
            };

            var resultado = await service.Guardar(tarifa);

            Assert.True(resultado);
            Assert.Equal(1, await context.Tarifas.CountAsync());
        }

        [Fact]
        public async Task Buscar_CuandoExisteTarifa_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedTipoVehiculo(context);

            var tarifa = new Tarifa
            {
                Id = 1,
                MinutosFraccion = 15,
                MinutosMinimo = 30,
                MinutosTolerancia = 5,
                PrecioPorFraccion = 25m,
                TipoVehiculoId = 1
            };

            context.Tarifas.Add(tarifa);
            await context.SaveChangesAsync();

            var service = new TarifaService(context);
            var encontrada = await service.Buscar(1);

            Assert.NotNull(encontrada);
            Assert.Equal(25m, encontrada!.PrecioPorFraccion);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteTarifa_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedTipoVehiculo(context);

            var tarifa = new Tarifa
            {
                Id = 1,
                MinutosFraccion = 20,
                MinutosMinimo = 40,
                MinutosTolerancia = 5,
                PrecioPorFraccion = 35m,
                TipoVehiculoId = 1
            };

            context.Tarifas.Add(tarifa);
            await context.SaveChangesAsync();

            var service = new TarifaService(context);
            var resultado = await service.Eliminar(1);

            Assert.True(resultado);
            Assert.Equal(0, await context.Tarifas.CountAsync());
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedTipoVehiculo(context);

            context.Tarifas.AddRange(
                new Tarifa
                {
                    Id = 1,
                    MinutosFraccion = 30,
                    MinutosMinimo = 60,
                    MinutosTolerancia = 10,
                    PrecioPorFraccion = 50m,
                    TipoVehiculoId = 1
                },
                new Tarifa
                {
                    Id = 2,
                    MinutosFraccion = 10,
                    MinutosMinimo = 20,
                    MinutosTolerancia = 5,
                    PrecioPorFraccion = 15m,
                    TipoVehiculoId = 1
                });

            await context.SaveChangesAsync();

            var service = new TarifaService(context);
            var resultados = await service.GetList(t => t.PrecioPorFraccion >= 50m);

            Assert.Single(resultados);
            Assert.Equal(60, resultados[0].MinutosMinimo);
        }

        [Fact]
        public async Task GetTiposVehiculo_CuandoHayRegistros_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedTipoVehiculo(context);

            var service = new TarifaService(context);
            var resultados = await service.GetTiposVehiculo();

            Assert.Single(resultados);
            Assert.Equal("Carro", resultados[0].Nombre);
        }

        private static async Task SeedTipoVehiculo(SmartparkContext context)
        {
            context.TiposVehiculos.Add(new TiposVehiculo
            {
                Id = 1,
                Nombre = "Carro"
            });

            await context.SaveChangesAsync();
        }
    }
}
