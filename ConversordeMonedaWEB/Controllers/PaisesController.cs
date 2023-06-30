using ConversordeMonedaWEB.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ConversordeMonedaWEB.Controllers
{
    public class PaisesController : Controller 
    {
        [HttpGet]
        public IActionResult EditarPais () 
        {
            var viewModel = new PaisesViewModel();


            viewModel.Titulo = "Editor de Paises";


            viewModel.Pais = new Negocio.Pais();
            viewModel.Pais.Nombre = "España";

            return View(viewModel);
        }
        [HttpPost]
        public IActionResult EditarPais(PaisesViewModel paisesViewModel)
        {
            return View(paisesViewModel);
        }
    }
}
