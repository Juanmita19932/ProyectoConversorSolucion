using Microsoft.Build.Framework;
using Negocio;

namespace ConversordeMonedaWEB.Models
{
    public class ConversorRepositorio : IConversorRepositorio
    {
    public List<Moneda> TraerTodaslasmonedas => new List<Moneda>
        {
            new Moneda{Id= 1, Nombre="Euro", Sigla= "EUR" },
            new Moneda{Id= 2, Nombre="Dollar", Sigla= "USD" },
            new Moneda{Id= 3, Nombre="Libra", Sigla= "GBP" },
        };

    public List<Usuario> TraerTodoslosusuarios => new List<Usuario>
        {
            new Usuario{Id= 1, Nombre="Juanma"},
        };
    public List<Factor> TraerTodoslofactores => new List<Factor>
        {

            new Factor {Id= 1, MonedaOrigen= "Euro", MonedaDestino="Dollar", FactorConversion= 1.1026},
            new Factor {Id= 2, MonedaOrigen="Dollar", MonedaDestino="Euro", FactorConversion = 0.9069},
            new Factor {Id=3 , MonedaOrigen="Euro", MonedaDestino="Libra", FactorConversion=  0.8772},
            new Factor {Id = 4,MonedaOrigen ="Libra",MonedaDestino="Euro" , FactorConversion = 1.1401},
            new Factor {Id= 5 , MonedaOrigen= "Dollar", MonedaDestino= "libra", FactorConversion =  0.81},
            new Factor {Id= 6 , MonedaOrigen= "libra" , MonedaDestino="Dollar", FactorConversion = 1.23}
         };
    public List<Historico> TraerHistorico => new List<Historico>
        {
            new Historico {Id =1 ,MonedaOrigen= "Euro", MonedaDestino= "Dollar",Fecha=DateTime.Now,FactorConversion= 1.1026 ,Usuario="Juanma", Valor=1 ,Resultado=1.1026 },
              new Historico {Id =2 ,MonedaOrigen= "Dollar", MonedaDestino= "Libra",Fecha=DateTime.Now,FactorConversion= 0.81 ,Usuario="Juanma", Valor=1 ,Resultado=0.81 }
        };





}
}
