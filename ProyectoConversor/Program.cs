using Negocio;

Console.WriteLine("");

//List<Historico> listaHistorico = new List<Historico>();

//Moneda euro = new Moneda();
//euro.Nombre = "Euro";
//euro.Sigla = "EUR";


//Moneda libra = new Moneda()
//{
//    Nombre = "Libra",
//    Sigla = "GBP"
//};


//Moneda dollar = new Moneda("Dollar", "USD");


//Factor factorEURUSD = new Factor(euro, dollar, 1.1026);
//Factor factorUSDEUR = new Factor(dollar, euro, 0.9069);
//Factor factorEURGBP = new Factor(euro, libra, 0.8772);
//Factor factorGBPEUR = new Factor(libra, euro, 1.1401);
//Factor factorUSDGBP = new Factor(dollar, libra, 0.81);
//Factor factorGBPUSD = new Factor(libra, dollar, 1.23);

//bool condicion = true;
//string inicioSalir = "";
//string tipoCambioelegido = "";
//Factor factorElegido = new Factor();
//double valoraConvertir = 0.0;
//string valoraConvertirTexto = "";

//double resultado = 0.0;

//Usuario Juanma = new Usuario();
//Juanma.Nombre = "Juanma";
//Juanma.Email = "email";


//while (condicion)
//{
//    Console.WriteLine("¡Bienvenidos al Conversor de moneda del Grupo 2!");
//    Console.WriteLine("MENÚ: (S) Salir, (C) Comenzar");
//    inicioSalir = Console.ReadLine();
//    if (inicioSalir == "C" || inicioSalir == "c")
//    {
//        Console.WriteLine("Bienvenido.");

//        Console.WriteLine("Tipos de Cambio");
//        Console.WriteLine("1. EUR a USD");
//        Console.WriteLine("2. USD a EUR");
//        Console.WriteLine("3. EUR a GBP");
//        Console.WriteLine("4. GBP a EUR");
//        Console.WriteLine("5. USD a GBP");
//        Console.WriteLine("6. GBP a USD");
//        Console.WriteLine();
//        Console.WriteLine("¿Que cambio desea realizar?");
//        tipoCambioelegido = Console.ReadLine();

//        if (tipoCambioelegido == "1")
//        {
//            factorElegido = factorEURUSD;

//        }
//        else if (tipoCambioelegido == "2")
//        {
//            factorElegido = factorUSDEUR;
//        }
//        else if (tipoCambioelegido == "3")
//        {
//            factorElegido = factorEURGBP;
//        }
//        else if (tipoCambioelegido == "4")
//        {
//            factorElegido = factorGBPEUR;
//        }
//        else if (tipoCambioelegido == "5")
//        {
//            factorElegido = factorUSDGBP;
//        }
//        else if (tipoCambioelegido == "6")
//        {
//            factorElegido = factorGBPUSD;
//        }
//        else
//        {
//            Console.WriteLine("Error al introducir el dato. Vuelva a introducirlo");
//        }
//        Console.WriteLine($"Va a convertir uster de {factorElegido.MonedaOrigen.Sigla} a {factorElegido.MonedaDestino.Sigla}");

//        Console.WriteLine("¿Que cantidad desea convertir?");
//        valoraConvertirTexto = Console.ReadLine();
//        valoraConvertir = Convert.ToDouble(valoraConvertirTexto);


//        resultado = valoraConvertir * factorElegido.FactorConversion;
//        Console.WriteLine($"El resultado de su operacion es:{resultado}{factorElegido.MonedaDestino.Sigla}");



//        // Crear en otra clase que vaya en Negocio.cs

//        Historico historico = new Historico();

//        historico.MonedaOrigen = factorElegido.MonedaOrigen;
//        historico.MonedaDestino = factorElegido.MonedaDestino;
//        historico.FactorConversion = factorElegido.FactorConversion;
//        historico.Fecha = DateTime.Now;
//        historico.Usuario = Juanma;
//        historico.Valor = valoraConvertir;
//        historico.Resultado = resultado;

//        listaHistorico.Add(historico);
//        Console.WriteLine($"Moneda Origen\t Moneda Destino\t FactorConversion\t Fecha\t Usuario\t Valor\t Resultado");
//        foreach (var historico1 in listaHistorico)
//        {
      
//            Console.WriteLine($"{historico1.MonedaOrigen.Sigla} \t {historico1.MonedaDestino.Sigla} \t {historico1.FactorConversion} \t {historico1.Fecha.ToShortDateString()}\t {historico1.Usuario} \t{historico1.Valor} \t{historico1.Resultado} ");
            
//        }
      


//    }
//    else if (inicioSalir == "S" || inicioSalir == "s")
//    {
//        condicion = false;
//    }
//    else
//    {
//        Console.WriteLine("Error al introducir el dato. Vuelva a introducirlo");
//    }









//}









