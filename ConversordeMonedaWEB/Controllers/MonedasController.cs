using ConversordeMonedaWEB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace ConversordeMonedaWEB.Controllers
{
    public class MonedasController: Controller
    {
        //Metodo de accion --> EditarMoneda
        //Ruta 
        [HttpGet]
        public IActionResult EditarMoneda ()
        {
            var viewModel = new MonedaViewModel();

            viewModel.Titulo = "Editor de Monedas";

            viewModel.Moneda = new Moneda();

            viewModel.Moneda.Id = 1;
            viewModel.Moneda.Nombre = "Euro";
            viewModel.Moneda.Sigla= "EUR";


             
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult EditarMoneda(MonedaViewModel monedaViewModel)
        {
            return View(monedaViewModel);
        }

        [HttpGet]


        public IActionResult ListaMonedas()
        {
            var viewModel = new MonedaViewModel();
            viewModel.ListaMonedas = new List<Moneda>()
            {
                new Moneda
                {
                    Id= 1,
                    Nombre= "Euro",
                    Sigla= "EUR",
               
                },
                new Moneda
                {
                    Id= 2,
                    Nombre= "Dollar",
                    Sigla ="USD",
                 
                },
                new Moneda
                {
                    Id= 3,
                    Nombre= "Libra",
                    Sigla="GBP",
                }
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult ListaMonedas(MonedaViewModel monedaViewModel)
        {
            return View(monedaViewModel);
        }

    }
}
