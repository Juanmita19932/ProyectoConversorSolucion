using Negocio;

namespace ConversordeMonedaWEB.Models
{
    public class ConversorRepositorioBaseDatos : IConversorRepositorio
    {
        public List<Moneda> TraerTodaslasmonedas => throw new NotImplementedException();

        public List<Usuario> TraerTodoslosusuarios => throw new NotImplementedException();

        public List<Factor> TraerTodoslofactores => throw new NotImplementedException();

        public List<Historico> TraerHistorico => throw new NotImplementedException();
    }
}
