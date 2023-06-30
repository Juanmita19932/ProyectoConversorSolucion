//using AspNetCore;
using ConversordeMonedaWEB.Models;
using ConversordeMonedaWEB.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Negocio;
using System.Diagnostics;

namespace ConversordeMonedaWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ContextoDatos _contexto;
        private readonly IConversorRepositorio _repositorio;
        public List<Moneda> Moneda  { get; set; }

        public List<Factor> ListaFactores { get; set; }
        public List<Historico> ListaHistorico { get; set; }



        //public HomeController(ILogger<HomeController> logger, IConversorRepositorio conversorRepositorio)
        //{

        //    _logger = logger;
        //    _repositorio = conversorRepositorio;

        //}
        public HomeController(ILogger<HomeController> logger, ContextoDatos contexto)
        {
            Moneda = new List<Moneda>()
            {
                new Moneda
                {
                    Id= 1,
                    Nombre= "Euro",
                    Sigla= "EUR"
                },
                new Moneda
                {
                    Id= 2,
                    Nombre= "Dollar",
                    Sigla ="USD"
                },
                new Moneda
                {
                    Id= 3,
                    Nombre= "Libra",
                    Sigla="GBP"
                }

            };

            ListaFactores = new List<Factor>()
            {
                new Factor
                {
                    Id = 1,
                    MonedaOrigen = "EUR",
                    MonedaDestino = "USD",
                    FactorConversion = 1.07230
                },

                new Factor
                {
                    Id = 2,
                    MonedaOrigen = "USD",
                    MonedaDestino = "EUR",
                    FactorConversion =  0.932571

                },
                new Factor
                {
                    Id = 3,
                    MonedaOrigen = "EUR",
                    MonedaDestino = "GBP",
                    FactorConversion = 0.864797
                },
                new Factor
                {
                    Id = 4,
                    MonedaOrigen = "GBP",
                    MonedaDestino = "EUR",
                    FactorConversion = 1.15634

                },
                new Factor
                {
                    Id = 5,
                    MonedaOrigen = "GBP",
                    MonedaDestino = "USD",
                    FactorConversion =  1.23990
                },
                new Factor
                {
                    Id = 6,
                    MonedaOrigen = "USD",
                    MonedaDestino = "GBP",
                    FactorConversion =  1.23990
                }

            };
            ListaHistorico = new List<Historico>()
            {
                new Historico 
                { 
                    Id = 1,
                    MonedaOrigen= "Euro",
                    MonedaDestino= "Dollar",
                    Usuario = "",
                    FactorConversion= 1.07230,
                    Valor= 1,
                    Resultado= 1,
                    Fecha= new DateTime(2023,06,02)
                   
                }

            };


            _logger = logger;
            _contexto = contexto;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();

            viewModel.Factor = new Factor();
            viewModel.Factor.MonedaOrigen = "Euro";
            viewModel.Factor.MonedaDestino = "Dollar";
            viewModel.Factor.FactorConversion = 1.123;
            viewModel.Resultado = 0;
            viewModel.Importe = 100;

            viewModel.ListaMoneda = Moneda;
            viewModel.ListaFactores = ListaFactores;
            viewModel.ListaHistorico= ListaHistorico;

            return View(viewModel);

        }
       
        [HttpPost]
        public IActionResult Index(HomeViewModel homeViewModel)
        {
            homeViewModel.ListaMoneda = this.Moneda;
            homeViewModel.ListaFactores = this.ListaFactores;
            homeViewModel.ListaHistorico = this.ListaHistorico;

            //// Obtener factor de conversion de moneda origen a moneda destino
            var factorSeleccionado = (from factorConversion in ListaFactores
                                      where factorConversion.MonedaOrigen == homeViewModel.MonedaOrigen &&
                                            factorConversion.MonedaDestino == homeViewModel.MonedaDestino
                                      select factorConversion.FactorConversion)
                                .FirstOrDefault();


            var resultado = homeViewModel.Importe * factorSeleccionado;
            homeViewModel.Resultado= resultado;

            ListaHistorico.Add(new Historico
            {
                Usuario = "Admin",
                MonedaOrigen = homeViewModel.MonedaOrigen,
                MonedaDestino = homeViewModel.MonedaDestino,
                FactorConversion = factorSeleccionado,
                Valor = homeViewModel.Importe,
                Resultado = homeViewModel.Resultado,
                Fecha = DateTime.Now

            }); ;
            homeViewModel.ListaHistorico = ListaHistorico;
          

            return View(homeViewModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}