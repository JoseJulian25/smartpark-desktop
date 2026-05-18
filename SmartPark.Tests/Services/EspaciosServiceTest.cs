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
                Estado = "LIBRE",
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
                Estado = "LIBRE",
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
                Estado = "LIBRE",
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
                    Estado = "LIBRE",
                    TipoVehiculoId = 1,
                    FechaCreacion = DateTime.UtcNow
                },
                new Espacio
                {
                    Activo = false,
                    CodigoEspacio = "E-005",
                    Estado = "LIBRE",
                    TipoVehiculoId = 1,
                    FechaCreacion = DateTime.UtcNow
                });

            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var resultados = await service.GetList(e => e.Activo);

            Assert.Single(resultados);
            Assert.Equal("E-004", resultados[0].CodigoEspacio);
        }

        [Fact]
        public async Task Guardar_CuandoEntidadEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new EspaciosService(context);

            var resultado = await service.Guardar(null!);

            Assert.False(resultado);
        }

        [Fact]
        public async Task Guardar_CuandoExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacio = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-EXISTE",
                Estado = "LIBRE",
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };
            context.Espacios.Add(espacio);
            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            
            espacio.CodigoEspacio = "E-MODIFICADO";
            var resultado = await service.Guardar(espacio);

            Assert.True(resultado);
            var modificado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacio.Id);
            Assert.Equal("E-MODIFICADO", modificado!.CodigoEspacio);
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new EspaciosService(context);

            var encontrado = await service.Buscar(999L);

            Assert.Null(encontrado);
        }

        [Fact]
        public async Task Eliminar_CuandoNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new EspaciosService(context);

            var resultado = await service.Eliminar(999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task MarcarReservadosHoyAsync_CuandoHayReservasHoy_MarcaEspaciosLibres()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacioLibre = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-RES-001",
                Estado = "LIBRE",
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            context.Espacios.Add(espacioLibre);
            await context.SaveChangesAsync();

            context.Reservas.Add(new Reserva
            {
                ClienteEmail = "demo@demo.com",
                ClienteNombreCompleto = "Demo",
                ClienteTelefono = "8090000000",
                CodigoReserva = "R-001",
                FechaCreacion = DateTime.UtcNow,
                HoraInicio = DateTime.Today.AddHours(10),
                Placa = "A123",
                EspacioId = espacioLibre.Id,
                TipoVehiculoId = 1,
                Estado = "PENDIENTE"
            });

            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var afectados = await service.MarcarReservadosHoyAsync();

            Assert.Equal(1, afectados);
            var actualizado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacioLibre.Id);
            Assert.Equal("RESERVADO", actualizado!.Estado);
        }

        [Fact]
        public async Task MarcarReservadosHoyAsync_CuandoNoAplica_NoModificaEspacios()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var espacioOcupado = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-RES-002",
                Estado = "OCUPADO",
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            var espacioLibre = new Espacio
            {
                Activo = true,
                CodigoEspacio = "E-RES-003",
                Estado = "LIBRE",
                TipoVehiculoId = 1,
                FechaCreacion = DateTime.UtcNow
            };

            context.Espacios.AddRange(espacioOcupado, espacioLibre);
            await context.SaveChangesAsync();

            context.Reservas.AddRange(
                new Reserva
                {
                    ClienteEmail = "demo2@demo.com",
                    ClienteNombreCompleto = "Demo2",
                    ClienteTelefono = "8090000001",
                    CodigoReserva = "R-002",
                    FechaCreacion = DateTime.UtcNow,
                    HoraInicio = DateTime.Today.AddDays(1).AddHours(9),
                    Placa = "B456",
                    EspacioId = espacioLibre.Id,
                    TipoVehiculoId = 1,
                    Estado = "PENDIENTE"
                },
                new Reserva
                {
                    ClienteEmail = "demo3@demo.com",
                    ClienteNombreCompleto = "Demo3",
                    ClienteTelefono = "8090000002",
                    CodigoReserva = "R-003",
                    FechaCreacion = DateTime.UtcNow,
                    HoraInicio = DateTime.Today.AddHours(11),
                    Placa = "C789",
                    EspacioId = espacioOcupado.Id,
                    TipoVehiculoId = 1,
                    Estado = "PENDIENTE"
                });

            await context.SaveChangesAsync();

            var service = new EspaciosService(context);
            var afectados = await service.MarcarReservadosHoyAsync();

            Assert.Equal(0, afectados);
            var libre = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacioLibre.Id);
            var ocupado = await context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == espacioOcupado.Id);
            Assert.Equal("LIBRE", libre!.Estado);
            Assert.Equal("OCUPADO", ocupado!.Estado);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
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
