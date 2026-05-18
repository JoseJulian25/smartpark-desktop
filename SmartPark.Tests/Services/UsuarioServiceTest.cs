using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;
using SmartPark.Tests.Infrastructure;
using SmartPark.UI.Services;

namespace SmartPark.Tests.Services
{
    public class UsuarioServiceTest
    {
        [Fact]
        public async Task Guardar_CuandoEsNuevo_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var service = new UsuarioService(context);
            var usuario = CreateUsuario("user1", "pass1", true, false);

            var resultado = await service.Guardar(usuario);

            Assert.True(resultado);
            Assert.Equal(1, await context.Usuarios.CountAsync());
        }

        [Fact]
        public async Task Guardar_CuandoExiste_RetornaTrue()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user2", "pass2", true, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            usuario.Nombre = "Usuario Actualizado";
            var resultado = await service.Guardar(usuario);

            Assert.True(resultado);
            var actualizado = await context.Usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Id == usuario.Id);
            Assert.Equal("Usuario Actualizado", actualizado!.Nombre);
        }

        [Fact]
        public async Task Guardar_CuandoEntidadEsNull_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new UsuarioService(context);

            var resultado = await service.Guardar(null!);

            Assert.False(resultado);
        }

        [Fact]
        public async Task Buscar_CuandoExiste_RetornaEntidad()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user3", "pass3", true, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var encontrado = await service.Buscar(usuario.Id);

            Assert.NotNull(encontrado);
            Assert.Equal("user3", encontrado!.Username);
            Assert.NotNull(encontrado.Rol);
        }

        [Fact]
        public async Task Buscar_CuandoNoExiste_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new UsuarioService(context);

            var encontrado = await service.Buscar(999L);

            Assert.Null(encontrado);
        }

        [Fact]
        public async Task Eliminar_CuandoExiste_DesactivaUsuario()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user4", "pass4", true, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var resultado = await service.Eliminar(usuario.Id);

            Assert.True(resultado);
            var actualizado = await context.Usuarios.AsNoTracking().FirstOrDefaultAsync(u => u.Id == usuario.Id);
            Assert.False(actualizado!.Activo);
            Assert.NotNull(actualizado.FechaEliminacion);
        }

        [Fact]
        public async Task Eliminar_CuandoNoExiste_RetornaFalse()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            var service = new UsuarioService(context);

            var resultado = await service.Eliminar(999L);

            Assert.False(resultado);
        }

        [Fact]
        public async Task GetList_CuandoHayCoincidencias_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            context.Usuarios.AddRange(
                CreateUsuario("user5", "pass5", true, false),
                CreateUsuario("user6", "pass6", false, false));

            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var resultados = await service.GetList(u => u.Activo);

            Assert.Single(resultados);
            Assert.Equal("user5", resultados[0].Username);
        }

        [Fact]
        public async Task GetRoles_CuandoExisteRol_RetornaLista()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var service = new UsuarioService(context);
            var roles = await service.GetRoles();

            Assert.Single(roles);
            Assert.Equal("Administrador", roles[0].Nombre);
        }

        [Fact]
        public async Task IniciarSesionAsync_CuandoCredencialesValidas_RetornaUsuario()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("Admin", "1234", true, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var autenticado = await service.IniciarSesionAsync("admin", "1234");

            Assert.NotNull(autenticado);
            Assert.Equal("Admin", autenticado!.Username);
        }

        [Fact]
        public async Task IniciarSesionAsync_CuandoInactivo_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user7", "pass7", false, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var autenticado = await service.IniciarSesionAsync("user7", "pass7");

            Assert.Null(autenticado);
        }

        [Fact]
        public async Task IniciarSesionAsync_CuandoEliminado_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user8", "pass8", true, true);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var autenticado = await service.IniciarSesionAsync("user8", "pass8");

            Assert.Null(autenticado);
        }

        [Fact]
        public async Task IniciarSesionAsync_CuandoCredencialesInvalidas_RetornaNull()
        {
            var databaseName = TestDBContextFactory.NewDatabaseName();
            await using var context = TestDBContextFactory.CreateContext(databaseName);
            await SeedBaseEntities(context);

            var usuario = CreateUsuario("user9", "pass9", true, false);
            context.Usuarios.Add(usuario);
            await context.SaveChangesAsync();

            var service = new UsuarioService(context);
            var autenticado = await service.IniciarSesionAsync("user9", "bad");

            Assert.Null(autenticado);
        }

        private static async Task SeedBaseEntities(SmartparkContext context)
        {
            context.Roles.Add(new Role { Id = 1, Nombre = "Administrador" });
            await context.SaveChangesAsync();
        }

        private static Usuario CreateUsuario(string username, string password, bool activo, bool eliminado)
        {
            return new Usuario
            {
                Nombre = "Usuario",
                Username = username,
                Password = password,
                Activo = activo,
                Eliminado = eliminado,
                FechaCreacion = DateTime.UtcNow,
                RolId = 1
            };
        }
    }
}
