using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Moneda : IEntidad
    {
       
        public string Nombre
        {
            get;
            set;
        }
        public string Sigla
        {
            get;
            set;
        }
        public string? Imagen { get; set; }
        public int Id { get; set; }
        

        //public Moneda()
        //{

        //}
        //public Moneda(string nombre, string sigla)
        //{
        //    Nombre = nombre;
        //    Sigla = sigla;
        //}

      
    }
}
