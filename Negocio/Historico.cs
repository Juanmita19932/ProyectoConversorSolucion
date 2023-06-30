using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Historico : IEntidad 
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
        public DateTime Fecha
        {
            get;
            set;
        }
        public double FactorConversion
        {
            get;
            set;
        }
        public string Usuario
        {
            get;
            set;
        }
        public double Valor
        {
            get;
            set;

        }
        public double Resultado
        {
            get;
            set;

        }
        public int Id { get; set; }
   


        public Historico() 
        {

        }
        //public Historico(Moneda monedaOrigen, Moneda monedaDestino, DateTime fecha, double factorConversion, Usuario usuario, double valor, double resultado)
        //{
        //    MonedaOrigen = monedaOrigen;
        //    MonedaDestino = monedaDestino;
        //    Fecha = fecha;
        //    FactorConversion = factorConversion;
        //    Usuario = usuario;
        //    Valor = valor;
        //    Resultado = resultado;

        //}
    }
}



