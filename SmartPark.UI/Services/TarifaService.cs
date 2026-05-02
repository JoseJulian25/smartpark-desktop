using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class TarifaService : IService<Tarifa, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public TarifaService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public TarifaService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Tarifa entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Tarifas.AddAsync(entidad);
            }
            else
            {
                _context.ChangeTracker.Clear();
                _context.Tarifas.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Tarifa?> Buscar(long id)
        {
            return await _context.Tarifas.AsNoTracking()
                .Include(t => t.TipoVehiculo)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Tarifas.FindAsync(id);
            if (entidad == null) return false;

            _context.Tarifas.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Tarifa>> GetList(Expression<Func<Tarifa, bool>> criterio)
        {
            return await _context.Tarifas.AsNoTracking()
                .Include(t => t.TipoVehiculo)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<TiposVehiculo>> GetTiposVehiculo()
        {
            return await _context.TiposVehiculos.AsNoTracking().ToListAsync();
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
