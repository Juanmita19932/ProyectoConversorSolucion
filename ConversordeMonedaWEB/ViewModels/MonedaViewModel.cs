using Negocio;

namespace ConversordeMonedaWEB.ViewModels
{
    public class MonedaViewModel
    {
        public string Titulo { get; set; }

        public Moneda Moneda { get;set; }

        public List<Moneda> ListaMonedas { get; set; }

    }
}
