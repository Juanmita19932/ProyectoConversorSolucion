using Negocio;

namespace ConversordeMonedaWEB.ViewModels
    
{
    public class RegistroViewModel
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string ConfirmarContraseña { get; set; }
        public string Email{ get;set;}
        public string Pais { get;set;}
        public DateTime FechadeNacimiento   { get; set; }

          public List<Pais> ListaPaises { get; set; }

        public string Estado { get; set; }

         public List<Usuario> ListaUsuarios  { get; set; }



    }
}
