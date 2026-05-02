using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class EspaciosService : IService<Espacio, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public EspaciosService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public EspaciosService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Espacio entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Espacios.AddAsync(entidad);
            }
            else
            {
                _context.Espacios.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Espacio?> Buscar(long id)
        {
            return await _context.Espacios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Espacios.FindAsync(id);
            if (entidad == null) return false;

            _context.Espacios.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Espacio>> GetList(Expression<Func<Espacio, bool>> criterio)
        {
            return await _context.Espacios
                .Include(e => e.Estado)
                .Include(e => e.TipoVehiculo)
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
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
