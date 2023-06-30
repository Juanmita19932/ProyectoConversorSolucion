using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Factor : IEntidad
    {
        public string MonedaOrigen 
        {
            get;
            set;
        }
        public string MonedaDestino
        { 
            get; 
            set; 
        }
        public double FactorConversion
        {
            get; 
            set;
        }
        public int Id { get; set; }
      

        //public Factor()
        //{

        //}
        //public Factor(Moneda monedaOrigen , Moneda monedaDestino, double factorConversion) 
        //{
        //    MonedaOrigen = monedaOrigen;
        //    MonedaDestino = monedaDestino;
        //    FactorConversion = factorConversion;

        //}
    }
}
