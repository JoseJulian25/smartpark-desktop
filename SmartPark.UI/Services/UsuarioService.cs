using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class UsuarioService : IService<Usuario, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public UsuarioService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public UsuarioService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Usuario entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Usuarios.AddAsync(entidad);
            }
            else
            {
                _context.ChangeTracker.Clear();
                _context.Usuarios.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Usuario?> Buscar(long id)
        {
            return await _context.Usuarios.AsNoTracking()
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Usuarios.FindAsync(id);
            if (entidad == null) return false;

            entidad.Activo = false;
            entidad.FechaEliminacion = DateTime.Now;
            _context.Usuarios.Update(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Usuario>> GetList(Expression<Func<Usuario, bool>> criterio)
        {
            return await _context.Usuarios.AsNoTracking()
                .Include(u => u.Rol)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Role>> GetRoles()
        {
            return await _context.Roles.AsNoTracking().ToListAsync();
        }

        public async Task<Usuario?> IniciarSesionAsync(string username, string password)
        {
            var normalized = username?.Trim().ToLowerInvariant();
            if (string.IsNullOrWhiteSpace(normalized) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return await _context.Usuarios.AsNoTracking()
                .Include(u => u.Rol)
                .FirstOrDefaultAsync(u => !u.Eliminado
                    && u.Activo
                    && u.Username.ToLower() == normalized
                    && u.Password == password);
        }

        public void Dispose()
        {
            if (_ownsContext)
            {
                _context?.Dispose();
            }
        }
    }
}
