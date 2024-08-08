using System;
using registroconsultapeliculas.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroconsultapeliculas.Repositorio
{
   public interface IRepositorioDatos
    {
        Task<List<Datos>> ObtenerTodos();
        Task<Datos?> ObtenerPorId(int id);
        Task<int> Crear (Datos datos);
    }
}
