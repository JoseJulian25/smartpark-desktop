using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class EmpresaServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);

            var service = new EmpresaService(context);
            var empresa = new Empresa
            {
                Direccion = "Av 1",
                Email = "info@demo.com",
                Nombre = "Demo",
                Rnc = "RNC-001",
                Telefono = "8090000000"
            };

            var resultado = await service.Guardar(empresa);

            Assert.True(resultado);
            Assert.Equal(1, await context.Empresas.CountAsync());
        }

        [Fact]
        public async Task Buscar_CuandoExisteEmpresa_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);

            var empresa = new Empresa
            {
                Id = 1,
                Direccion = "Av 2",
                Email = "info2@demo.com",
                Nombre = "Demo2",
                Rnc = "RNC-002",
                Telefono = "8090000001"
            };

            context.Empresas.Add(empresa);
            await context.SaveChangesAsync();

            var service = new EmpresaService(context);
            var encontrada = await service.Buscar(1L);

            Assert.NotNull(encontrada);
            Assert.Equal("Demo2", encontrada!.Nombre);
        }

        [Fact]
        public async Task Eliminar_CuandoExisteEmpresa_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);

            var empresa = new Empresa
            {
                Id = 1,
                Direccion = "Av 3",
                Email = "info3@demo.com",
                Nombre = "Demo3",
                Rnc = "RNC-003",
                Telefono = "8090000002"
            };

            context.Empresas.Add(empresa);
            await context.SaveChangesAsync();

            var service = new EmpresaService(context);
            var resultado = await service.Eliminar(1L);

            Assert.True(resultado);
            Assert.Equal(0, await context.Empresas.CountAsync());
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);

            context.Empresas.AddRange(
                new Empresa
                {
                    Id = 1,
                    Direccion = "Av 4",
                    Email = "info4@demo.com",
                    Nombre = "Activa",
                    Rnc = "RNC-004",
                    Telefono = "8090000003"
                },
                new Empresa
                {
                    Id = 2,
                    Direccion = "Av 5",
                    Email = "info5@demo.com",
                    Nombre = "Inactiva",
                    Rnc = "RNC-005",
                    Telefono = "8090000004"
                });

            await context.SaveChangesAsync();

            var service = new EmpresaService(context);
            var resultados = await service.GetList(e => e.Nombre == "Activa");

            Assert.Single(resultados);
            Assert.Equal("RNC-004", resultados[0].Rnc);
        }
    }
}
