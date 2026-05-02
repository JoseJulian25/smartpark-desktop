using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class PagoService : IService<Pago, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public PagoService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public PagoService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Pago entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
            {
                await _context.Pagos.AddAsync(entidad);
            }
            else
            {
                _context.Pagos.Update(entidad);
            }

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Pago?> Buscar(long id)
        {
            return await _context.Pagos.AsNoTracking()
                .Include(p => p.Ticket)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Pagos.FindAsync(id);
            if (entidad == null) return false;

            _context.Pagos.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Pago>> GetList(Expression<Func<Pago, bool>> criterio)
        {
            return await _context.Pagos.AsNoTracking()
                .Include(p => p.Ticket)
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> RegistrarCobro(Pago pago, long ticketId)
        {
            if (pago == null || ticketId <= 0) return false;

            var ticket = await _context.Tickets
                .Include(t => t.Espacio)
                .FirstOrDefaultAsync(t => t.Id == ticketId);

            if (ticket == null || ticket.Espacio == null)
            {
                return false;
            }

            var now = DateTime.Now;
            pago.HoraPago = now;
            pago.TicketId = ticket.Id;

            ticket.HoraSalida = now;
            ticket.MontoTotal = pago.Monto;
            ticket.EstadoId = 2;
            ticket.Espacio.EstadoId = 1;

            await _context.Pagos.AddAsync(pago);

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