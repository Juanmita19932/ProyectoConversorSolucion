using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio 
{
    public class Usuario : IEntidad
    {
        public string Nombre
        {
            get;
            set;
        }
        public string Contraseña
        {
            get;
            set;
        }
        public string ConfirmarContraseña 
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Pais 
        { 
            get; 
            set; 
        }
        public DateTime FechadeNacimiento
        {
            get; 
            set;
        }
        
        public int Id { get; set; }
       

        public Usuario()
        {

        }
        public Usuario(string nombre, string contraseña, string email, string pais,DateTime fechadeNacimiento, string confirmarContraseña)      
        {
            Nombre = nombre;
            Contraseña = contraseña;
            Email = email;
            Pais = pais;    
            FechadeNacimiento = fechadeNacimiento;
            ConfirmarContraseña = confirmarContraseña;
        }

    }

}
