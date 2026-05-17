using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class ReservaService : IService<Reserva, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public ReservaService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public ReservaService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Reserva entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Reservas.AddAsync(entidad);
            }
            else
            {
                _context.ChangeTracker.Clear();
                _context.Reservas.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Reserva?> Buscar(long id)
        {
            return await _context.Reservas.AsNoTracking()
                .Include(r => r.Espacio)
                .Include(r => r.TipoVehiculo)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Reservas.FindAsync(id);
            if (entidad == null) return false;

            _context.Reservas.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Reserva>> GetList(Expression<Func<Reserva, bool>> criterio)
        {
            return await _context.Reservas.AsNoTracking()
                .Include(r => r.Espacio)
                .Include(r => r.TipoVehiculo)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Reserva>> GetReservas(DateTime? fecha, string? estado, string? cliente)
        {
            var query = _context.Reservas.AsNoTracking()
                .Include(r => r.Espacio)
                .Include(r => r.TipoVehiculo)
                .AsQueryable();

            if (fecha.HasValue)
            {
                var dia = fecha.Value.Date;
                query = query.Where(r => r.HoraInicio.Date == dia);
            }

            if (!string.IsNullOrWhiteSpace(estado) && !string.Equals(estado, "Todos", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(r => r.Estado == estado);
            }

            if (!string.IsNullOrWhiteSpace(cliente))
            {
                query = query.Where(r => r.ClienteNombreCompleto.Contains(cliente));
            }

            return await query
                .OrderByDescending(r => r.HoraInicio)
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
