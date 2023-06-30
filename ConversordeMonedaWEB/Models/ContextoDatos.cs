using Microsoft.EntityFrameworkCore;
using Negocio;

namespace ConversordeMonedaWEB.Models
{
    public class ContextoDatos : DbContext 
    {
        public ContextoDatos(DbContextOptions<ContextoDatos>opciones) 
            : base(opciones)
        {

        }

        //Tabla de Monedas
        public DbSet<Moneda> Monedas { get; set; }

        //Tabla Factor
        public DbSet<Factor> Factores { get; set; }
        //Tabla Usuario
        public DbSet<Usuario> Usuarios { get; set; }

        //Tabla Historico
        public DbSet<Historico> Historicos { get; set; }

        //Tabla Paises
        public DbSet<Pais> Paises {  get; set; }
    }
}
