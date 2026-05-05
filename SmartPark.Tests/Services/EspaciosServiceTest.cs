using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class EspaciosServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var service = new EspaciosService(context);
            var espacio = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-001",
                EstadoId = 1,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            var resultado = await service.Guardar(espacio);

            Assert.True(resultado);
            Assert.Equal(1, await context.Espacios.CountAsync());
        }

        [Fact]
        public async Task Buscar_CuandoExisteEspacio_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-002",
                EstadoId = 1,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var encontrado = await service.Buscar(espacio.Id);

            Assert.NotNull(encontrado);
            Assert.Equal("E-002", encontrado!.CodigoEspacio);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteEspacio_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-003",
                EstadoId = 1,
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var resultado = await service.Eliminar(espacio.Id);

            Assert.True(resultado);
            Assert.Equal(0, await context.Espacios.CountAsync());
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            context.Espacios.AddRange(
                new Espacio
                {
                    Activo = true,
                    CodigoEspacio = "E-004",
                    EstadoId = 1,
                    TipoVehiculoId = 1,
                    FechaCreacion = DateTime.UtcNow
                },
                new Espacio
                {
                    Activo = false,
                    CodigoEspacio = "E-005",
                    EstadoId = 1,
                    TipoVehiculoId = 1,
                    FechaCreacion = DateTime.UtcNow
                });

            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var resultados = await service.GetList(e => e.Activo);

            Assert.Single(resultados);
            Assert.Equal("E-004", resultados[0].CodigoEspacio);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
        {
            context.EstadosEspacios.Add(new EstadosEspacio
            {
                Id = 1,
                Nombre = "Disponible"
            });

            context.TiposVehiculos.Add(new TiposVehiculo
            {
                Id = 1,
                Nombre = "Carro"
            });

            await context.SaveChangesAsync();
        }
    }
}
