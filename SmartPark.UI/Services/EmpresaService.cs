using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartPark.Data;
using SmartPark.Data.Modelos;

namespace SmartPark.UI.Services
{
    public class EmpresaService : IService<Empresa, long>, IDisposable
    {
        private readonly SmartparkContext _context;
        private readonly bool _ownsContext;

        public EmpresaService(SmartparkContext context)
        {
            _context = context;
            _ownsContext = false;
        }

        public EmpresaService()
        {
            _context = new SmartparkContext();
            _ownsContext = true;
        }

        public async Task<bool> Guardar(Empresa entidad)
        {
            if (entidad == null) return false;

            if (entidad.Id == 0)
                await _context.Empresas.AddAsync(entidad);
            else
                _context.Empresas.Update(entidad);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Empresa?> Buscar(long id)
        {
            return await _context.Empresas.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> Eliminar(long id)
        {
            var entidad = await _context.Empresas.FindAsync(id);
            if (entidad == null) return false;

            _context.Empresas.Remove(entidad);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<Empresa>> GetList(Expression<Func<Empresa, bool>> criterio)
        {
            return await _context.Empresas.AsNoTracking().Where(criterio).ToListAsync();
        }

        public void Dispose()
        {
            if (_ownsContext)
                _context?.Dispose();
        }
    }
}
