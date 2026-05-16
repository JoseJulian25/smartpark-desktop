using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class ConsultasService : IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public ConsultasService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public ConsultasService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<List<Ticket>> GetHistorialEntradasSalidas(
            DateTime fechaInicio,
            DateTime fechaFin,
            string? placa,
            string? ticket)
        {
            var inicio = fechaInicio.Date;
            var fin = fechaFin.Date.AddDays(1).AddTicks(-1);

            var query = _context.Tickets.AsNoTracking()
                .Include(t => t.Espacio)
                    .ThenInclude(e => e.TipoVehiculo)
                .Include(t => t.CreadoPorNavigation)
                .Where(t => t.HoraEntrada >= inicio && t.HoraEntrada <= fin);

            if (!string.IsNullOrWhiteSpace(placa))
                query = query.Where(t => t.Placa.Contains(placa));

            if (!string.IsNullOrWhiteSpace(ticket))
                query = query.Where(t => t.CodigoTicket.Contains(ticket));

            return await query
                .OrderByDescending(t => t.HoraEntrada)
                .ToListAsync();
        }

        public async Task<List<Pago>> GetPagos(
            DateTime fechaInicio,
            DateTime fechaFin,
            string? metodo,
            string? ticket)
        {
            var inicio = fechaInicio.Date;
            var fin = fechaFin.Date.AddDays(1).AddTicks(-1);

            var query = _context.Pagos.AsNoTracking()
                .Include(p => p.Ticket)
                .Include(p => p.ProcesadoPorNavigation)
                .Where(p => p.HoraPago >= inicio && p.HoraPago <= fin);

            if (!string.IsNullOrWhiteSpace(metodo) && !string.Equals(metodo, "Todos", StringComparison.OrdinalIgnoreCase))
                query = query.Where(p => p.MetodoPago == metodo);
    

            if (!string.IsNullOrWhiteSpace(ticket))
                        query = query.Where(p => p.Ticket.CodigoTicket.Contains(ticket));

            return await query
                .OrderByDescending(p => p.HoraPago)
                .ToListAsync();
        }

        public static string BuildTiempo(DateTime entrada, DateTime? salida)
        {
            if (!salida.HasValue)
                return string.Empty;
            

            var span = salida.Value - entrada;
            if (span.TotalMinutes < 0)
                return string.Empty;

            var horas = (int)span.TotalHours;
            var minutos = span.Minutes;
            return $"{horas}h {minutos}m";
        }

        public void Dispose()
        {
            if (_ownsContext)
                _context?.Dispose();
        }

    }
}
