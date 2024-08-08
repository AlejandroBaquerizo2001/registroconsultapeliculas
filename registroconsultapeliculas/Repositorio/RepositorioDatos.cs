using Microsoft.EntityFrameworkCore;
using registroconsultapeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroconsultapeliculas.Repositorio
{
    public class RepositorioDatos : IRepositorioDatos
    {
        private readonly AplicationDBContext context;
        public RepositorioDatos (AplicationDBContext context)
        {
            this.context = context;
        }

        public async Task<int> Crear(Datos datos)
        {
            context.Datos.Add(datos);
            await context.SaveChangesAsync();
            return datos.Id;
        }

        public async Task<Datos?> ObtenerPorId(int id)
        {
            return context.Datos.Where(x => x.Id == id)
                .ToList()[0];
        }

        public async Task<List<Datos>> ObtenerTodos()
        {
            return await context.Datos.ToListAsync();
        }
    }
}
