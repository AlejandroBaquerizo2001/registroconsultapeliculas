using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroconsultapeliculas.Entidades
{
    public class AplicationDBContext : DbContext
    {
     
           public AplicationDBContext(DbContextOptions options) : base (options)
          {
          }
  
       /*    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=registroconsultpeli;Integrated Security=True; TrustServerCertificate=True;");

        }}*/
        public DbSet<Datos> Datos { get; set; }

        public DbSet<Referencia> Referencias { get; set; }
    }
}
