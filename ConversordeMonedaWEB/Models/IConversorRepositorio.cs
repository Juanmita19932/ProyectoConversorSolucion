using Negocio;

namespace ConversordeMonedaWEB.Models
{



    public interface IConversorRepositorio
    {
        //Traer todas las monedas
        List<Moneda> TraerTodaslasmonedas { get; }



        //Traer todos los usuarios
        List<Usuario> TraerTodoslosusuarios { get; }


        //Traer todos los factores de conversion
        List<Factor> TraerTodoslofactores { get; }

        //Traer el historico+
        List<Historico> TraerHistorico { get; }


        //Agregar nueva conversion al historico de conversiones
        //Agregar nuevo usuario
        // Login
        //Agregar nueva moneda
        //Borrar moneda
        //Borrar usuario
        //Borrar entrada del historico
    }
}
