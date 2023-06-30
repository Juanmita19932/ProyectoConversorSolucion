using Negocio;

namespace ConversordeMonedaWEB.ViewModels
{
    public class HomeViewModel
    {
        public Factor Factor { get; set; }

        public double Resultado { get; set; }
        public double Importe { get; set; } 


        public List<Historico> ListaHistorico { get; set; }
        public List<Factor> ListaFactores { get; set; }

        public List<Moneda> ListaMoneda { get; set; }

        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }  


    }
}
