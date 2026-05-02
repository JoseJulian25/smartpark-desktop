using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SmartPark.UI.Services
{
    public interface IService<T, TKey> where T : class
    {
        Task<bool> Guardar(T entidad);
        Task<T?> Buscar(TKey id);
        Task<bool> Eliminar(TKey id);
        Task<List<T>> GetList(Expression<Func<T, bool>> criterio);
    }
}
