using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class TicketService : IService<Ticket, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public TicketService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public TicketService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Ticket entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Tickets.AddAsync(entidad);
            }
            else
            {
                _context.Tickets.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Ticket?> Buscar(long id)
        {
            return await _context.Tickets.AsNoTracking()
                .Include(t => t.Espacio)
                    .ThenInclude(e => e.TipoVehiculo)
                .Include(t => t.Estado)
                .Include(t => t.Pago)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Tickets.FindAsync(id);
            if (entidad == null) return false;

            _context.Tickets.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Ticket>> GetList(Expression<Func<Ticket, bool>> criterio)
        {
            return await _context.Tickets.AsNoTracking()
                .Include(t => t.Espacio)
                    .ThenInclude(e => e.TipoVehiculo)
                .Include(t => t.Estado)
                .Include(t => t.Pago)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> RegistrarEntrada(Ticket ticket, long espacioId)
        {
            if (ticket == null || espacioId <= 0) return false;

            var espacio = await _context.Espacios.FirstOrDefaultAsync(e => e.Id == espacioId);
            if (espacio == null || espacio.EstadoId != 1)
            {
                return false;
            }

            var now = DateTime.Now;
            ticket.CodigoTicket = string.IsNullOrWhiteSpace(ticket.CodigoTicket)
                ? $"T-{now:yyyyMMddHHmmssfff}"
                : ticket.CodigoTicket;
            ticket.FechaCreacion = now;
            ticket.HoraEntrada = now;
            ticket.HoraSalida = null;
            ticket.MontoTotal = null;
            ticket.EspacioId = espacioId;
            ticket.EstadoId = 1;

            await _context.Tickets.AddAsync(ticket);
            espacio.EstadoId = 2;

            return await _context.SaveChangesAsync() > 0;
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