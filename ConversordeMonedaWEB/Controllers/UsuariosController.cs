using ConversordeMonedaWEB.Models;
using ConversordeMonedaWEB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.ComponentModel.DataAnnotations;

namespace ConversordeMonedaWEB.Controllers
{


    public class UsuariosController : Controller
    {
        public List<Pais> ListaPaises { get; set; }
        public List<Usuario> ListaUsuarios { get; set; }

        public UsuariosController()
        {
            ListaPaises = new List<Pais>
            {
            new Pais { Nombre = "España" },
            new Pais { Nombre = "Estados Unidos" },
            new Pais { Nombre = "Reino Unido" }
            };
            ListaUsuarios = new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Email= "juanma@mail.com",
                    Contraseña= "1234"
                },
                new Usuario
                {
                    Id= 2,
                    Email="rafa@mail.com",
                    Contraseña="1234"
                }
            };


        }
        [HttpGet]
        public IActionResult Registro()
        {


            var viewmodel = new RegistroViewModel
            {
                ListaPaises = this.ListaPaises
            };

            return View(viewmodel);


        }
        [HttpPost]
        public IActionResult Registro(RegistroViewModel registroViewModel)
        {
            if (registroViewModel.Contraseña != registroViewModel.ConfirmarContraseña)
            {
                registroViewModel.Estado = "Las contraseñas no coinciden";
            }
            else
            {
                registroViewModel.Estado = "";
                ListaUsuarios.Add(new Usuario
                {
                    Nombre = registroViewModel.Nombre,
                    Email = registroViewModel.Email,
                    Contraseña = registroViewModel.Contraseña,
                    ConfirmarContraseña=registroViewModel.ConfirmarContraseña,
                    FechadeNacimiento=registroViewModel.FechadeNacimiento,
                    Pais=registroViewModel.Pais
                });

                return RedirectToAction("Login", "Usuarios");
            }
            registroViewModel.ListaPaises = this.ListaPaises;

            return View(registroViewModel);
        }



        [HttpGet]
        public IActionResult Login()
        {
            var viewModel = new LoginViewModel();


            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Login (LoginViewModel loginViewModel)
        {

            var usuarioLogin = (from usuario in ListaUsuarios 
                                      where usuario.Email ==  loginViewModel.Email &&
                                            usuario.Contraseña == loginViewModel.Contraseña
                                      select usuario)
                              .FirstOrDefault();
            if (usuarioLogin != null)
            {
                loginViewModel.Estado = "Bienvenido";
                 return RedirectToAction("Index", "Home");
            }
            else
            {
                loginViewModel.Estado = "Usuario Incorrecto";
            }
            


            return View(loginViewModel);
        }
    }
}
