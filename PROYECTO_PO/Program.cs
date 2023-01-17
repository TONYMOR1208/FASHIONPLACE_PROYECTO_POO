internal class Program
{
    private static void Main(string[] args)
    {
  
      Ficha_Vendedor F_vende = new Ficha_Vendedor(7896356, 1307895622, " Julio ", " Flores ", " juio87@gmail.com ", 38, 0987851913, " Las Cumbres", " Mayor edad , Experencia Previa ,  Aprendizaje proactivo    ", " Ventas de trajes formales  ", " Catalogo de las vestimenatas ");
 
      Ficha_Usuario F_usu = new Ficha_Usuario(126647893, 1361798123, " Mario ", " Perez ", " Mario1995@gmail.com ", 25, 0934547727, " Calle 110 Av 12 ", " Forma de pago aun por especificar");


      Ficha_Administrador Admin = new Ficha_Administrador(546758, 1316718111, " Joel ", " Catagua ", " ajmc1316718111@gmail.com ", 21, 0981851234, " Leonidas Proaño ", " Contar con una experiencia laboral de 2 años  ", " Diseñador de modas  ");

      var FichaU = new Ficha_Usuario(126647893, 1361798123, " Mario ", " Perez ", " Mario1995@gmail.com ",
      25, 0934547727, " Calle 110 Av 12 ", " Forma de pago aun por especificar");
      var item_1 = new item_1(FichaU);
   
      var item_2 = new item_2(FichaU);
      

      Requisitos_Funcionales requi = new Requisitos_Funcionales();


        //Para finalizar añadimos el método cuantificar de la clase Decorador.

        String Iniciar = "";
        while (Iniciar != "Iniciar")
        {
            F_vende.Servicio();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- Iniciar sesión ");
            Console.WriteLine("2- Registrar ");
            Console.WriteLine(" ");
            Iniciar = Console.ReadLine();

            switch (Iniciar)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("Usuario o correo electronico (Pueden ser palabras random) ");
                    Iniciar = Console.ReadLine();
                    Console.WriteLine("Contraseña ");
                    Iniciar = Console.ReadLine();
                    Console.WriteLine("Escribir (Iniciar) para entra a la tienda ");
                    Iniciar = Console.ReadLine();
                    break;
            }
            switch (Iniciar)
            {
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Ingresar un usuario o correo electronico");
                    Iniciar = Console.ReadLine();
                    Console.WriteLine("Contraseña ");
                    string Iniciar1 = Console.ReadLine();
                    Console.WriteLine(" Repiter  tu contraseña ");
                    string Iniciar2 = Console.ReadLine();
                    if (Iniciar1 == Iniciar2)
                    {
                        Console.WriteLine("Escribir (Iniciar) para entra a la tienda ");
                        Iniciar = Console.ReadLine();
                    }
                    break;
            }
        }
        string input= "";
   while(input!="0")
   {    
      F_vende.Servicio();
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Bienvenido en que te puedo ayudar"); 
      Console.WriteLine("1- Usuario");
      Console.WriteLine("2- Requisitos");
      Console.WriteLine("3- Requerimientos ");;
      Console.WriteLine("4- Catalogo");
      Console.WriteLine("5- Metodos de Pago");
      Console.WriteLine("0- Salir");
   input = Console.ReadLine();
  
   switch (input)
   {
      case "1":
      Console.WriteLine("");
      Console.WriteLine("Usuario");
      Console.WriteLine("");
      Console.WriteLine("1- Ficha de Usuario ");
      Console.WriteLine("2- Ficha de Vendedor");
      Console.WriteLine("3- Ficha de Administrador");;
      Console.WriteLine("0- Salir");
      input = Console.ReadLine();
      switch (input)
   {
      case "1":
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue; 
      Console.WriteLine("Datos del Usuario");
      Console.WriteLine();
      F_usu.ImprimirDatos(); 
      break;

      case "2":
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue; 
      Console.WriteLine("Datos del Vendedor");
      Console.WriteLine();
      F_vende.ImprimirDatos();
      break;

      case "3":
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Blue; 
      Console.WriteLine("Datos del Administrador");
      Console.WriteLine();
      Admin.ImprimirDatos();
      break;

      case "0":
      Console.Clear(); 
      Console.WriteLine("GRACIAS POR SU VISITA");
      break;
      default:
      Console.Clear();
      
      Console.WriteLine("Ingreso un caracter no valido");
      Console.WriteLine("Vuelva a intentarlo");
      break;
   }
      break;

      case "2":
      Console.Clear();
      Console.WriteLine("Requisitos");
      Console.WriteLine("1- Requisitos legales");
      Console.WriteLine("2- Requisitos Funcionales");
      Console.WriteLine("0- Salir");
      input = Console.ReadLine();  
      switch (input)
      {
         case "1":
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Blue; 
         Console.WriteLine("Requisitos legales");
         Console.WriteLine();
         F_vende.legales();
         break;

         case "2":
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.Blue; 
         Console.WriteLine("Requisitos Funcionales");
         Console.WriteLine();
         requi.requisitos();
         break;

         case "0":
         Console.Clear();
         Console.WriteLine("GRACIAS POR SU VISITA");
         Console.WriteLine();
         break;
         default:
         Console.Clear();
         Console.WriteLine("Ingreso un caracter no valido");
         Console.WriteLine("Vuelva a intentarlo");
         Console.WriteLine();
         break;
      }
         break;
         case "3":
         Console.Clear();
         Console.WriteLine("Requerimientos");
         Console.WriteLine("1- Requerimientos");
         Console.WriteLine("0- Salir");
         input = Console.ReadLine();               
         switch (input)
         {
            case "1":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Requerimientos");
            Console.WriteLine();
            Admin.Servicio();
            break;

            case "0":
            Console.Clear();
            Console.WriteLine("GRACIAS POR SU VISITA");
            Console.WriteLine();
            break;
            default:
            Console.Clear();
            Console.WriteLine("Ingreso un caracter no valido");
            Console.WriteLine("Vuelva a intentarlo");
            break;
         }
            break;
            case "4":
            Console.Clear();
            Console.WriteLine("Ofertas");
            Console.WriteLine("");
            Console.WriteLine("1- Trajes de bodas");
            Console.WriteLine("2- Trajes de quinceañera");
            Console.WriteLine("3- Trajes de Bautizo");
            Console.WriteLine("0- Salir");
            input = Console.ReadLine();               

            switch (input)
               {
                  case "1":
                  Console.Clear();
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("Trajes de bodas");
                  Console.WriteLine();
                  F_vende.venta_boda();
                  break;

                  case "2":
                  Console.Clear();
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("Trajes de quinceañera");
                  Console.WriteLine();
                  F_vende.venta_quinceañera();
                  break;

                  case "3":
                  Console.Clear();
                  Console.ForegroundColor = ConsoleColor.Blue;
                  Console.WriteLine("Trajes de bautizo");
                  Console.WriteLine();
                  F_vende.venta_bautizo();
               

                  break;
                        
                  case "0":
                  Console.Clear();
                  Console.WriteLine("GRACIAS POR SU VISITA");
                  Console.WriteLine();
                  break;
                  default:
                  Console.Clear();
                  Console.WriteLine("Ingreso un caracter no valido");
                  Console.WriteLine("Vuelva a intentarlo");
                  break;
               }
               
                  break;
                     case "5":
                     Console.Clear();
                     Console.WriteLine("Metodos de Pago");
                     Console.WriteLine();
                     Console.WriteLine("1- Efectivo");
                     Console.WriteLine("2- Tarjeta de creditos");
                     Console.WriteLine("3- Tarjeta de debitos");
                     Console.WriteLine("0- Salir");
                     input = Console.ReadLine();               

                     switch (input)
                     {
                        case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Efectivo");
                        Console.WriteLine();
                        F_usu.pago_efectivo();
                        break;

                        case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Creditos");
                        Console.WriteLine();
                        F_usu.pago_credito();
                        break;

                        case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Debitos");
                        Console.WriteLine();
                        F_usu.pago_debito();
                        break;

                        case "0":
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR SU VISITA");
                        Console.WriteLine();
                        break;
                        
                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;
                    }
                        break;
                        case "0":
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR SU VISITA");
                        Console.WriteLine();
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Ingreso un caracter no valido");
                        Console.WriteLine("Vuelva a intentarlo");
                        break;

            }
      }
  
    
    
    }

    }
       




    