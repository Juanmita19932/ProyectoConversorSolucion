using Negocio;

namespace ConversordeMonedaWEB.ViewModels
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public List<Usuario> ListaUsuarios  { get; set; }
        public string Estado { get; set; }

        
    }
}
