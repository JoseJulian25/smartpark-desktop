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
                _context.ChangeTracker.Clear();
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
                .Include(e => e.TipoVehiculo)
                .Where(criterio)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<bool> TieneTicketsAsync(long espacioId)
        {
            return await _context.Tickets.AsNoTracking().AnyAsync(t => t.EspacioId == espacioId);
        }

        public async Task<int> MarcarReservadosHoyAsync()
        {
            var hoy = DateTime.Today;
            var reservados = await _context.Reservas
                .Where(r => r.HoraInicio.Date == hoy && (r.Estado == "PENDIENTE" || r.Estado == "ACTIVA"))
                .Select(r => r.EspacioId)
                .Distinct()
                .ToListAsync();

            if (reservados.Count == 0)
                return 0;

            var espacios = await _context.Espacios
                .Where(e => reservados.Contains(e.Id) && e.Estado == "LIBRE")
                .ToListAsync();

            if (espacios.Count == 0)
                return 0;

            foreach (var espacio in espacios)
            {
                espacio.Estado = "RESERVADO";
            }

            return await _context.SaveChangesAsync();
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
