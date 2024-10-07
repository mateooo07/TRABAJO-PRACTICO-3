using System;
using System.Runtime.InteropServices;

class TrabajoPractico3
{
    
    static bool vueloCreado = false;
    static bool asientoReservado = false;
    static int opcion = 1;
    static bool asientoDesocupado = false;

    static void Main()
    {
        Inicio();
        Menú();
        
    }
    static int[][] asientos = Vuelo();
    static void Inicio() // Función correspondiente a la pantalla de bienvenida.
    {
        Console.CursorVisible = false;
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("|¡Bienvenido a Aerolíneas Argentinas!|");
        Console.WriteLine("--------------------------------------");
        Bandera();
        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
    }
    
    static void Bandera()
    {
        ConsoleColor colorCeleste = ConsoleColor.Cyan;
        ConsoleColor colorBlanco = ConsoleColor.White;
        int ancho = 40;
        int alto = 9;

        for (int i = 0; i < alto; i++)
        {

            if (i < 3)
            {
                Console.BackgroundColor = colorCeleste;
            }
            else if (i >= 3 && i < 6)
            {
                Console.BackgroundColor = colorBlanco;
            }
            else
            {
                Console.BackgroundColor = colorCeleste;
            }


            Console.WriteLine(new string(' ', ancho));
        }
        Console.ResetColor();
    }

    static void Menú() //Función correspondiente al menu principal del programa.
    {
        int opcion = 0; 
        ConsoleKeyInfo Flecha;
        Console.CursorVisible = false;
        

        do
        {
            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine("|| MENÚ ||");
            Console.WriteLine("----------\n");

            
            for (int i = 0; i <= 6; i++)
            {
                if (opcion == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine($"{MenuNumeros(i)}");
                    Console.ResetColor(); 
                }
                else
                {
                    
                    Console.WriteLine($" {MenuNumeros(i)}");
                }
            }

            
            Flecha = Console.ReadKey(true);
            if (Flecha.Key == ConsoleKey.UpArrow && opcion > 0) opcion--;
            if (Flecha.Key == ConsoleKey.DownArrow && opcion < 7) opcion++;

        } while (Flecha.Key != ConsoleKey.Enter); 
        switch (opcion)
        {
            case 0:
                
                EsperarYVolverAlMenu();
                break;
            case 1:
                if (vueloCreado)
                {
                    ReservarAsiento();
                    EsperarYVolverAlMenu();
                }
                else
                {
                    Console.WriteLine("\nPrimero debe crear un vuelo antes de reservar un asiento.");
                }
                break;
            case 2:
                
                Console.WriteLine("Funcionalidad no implementada.");
                EsperarYVolverAlMenu();
                break;
            case 3:
                
                Console.WriteLine("Funcionalidad no implementada.");
                EsperarYVolverAlMenu();
                break;
            case 4:
                
                Console.WriteLine("Funcionalidad no implementada.");
                EsperarYVolverAlMenu();
                break;
            case 5:
                
                Console.WriteLine("Funcionalidad no implementada.");
                EsperarYVolverAlMenu();
                break;
            case 6:
               
                Console.WriteLine("Saliendo del sistema...");
                break;
        }
    }

    static string MenuNumeros(int indice) // Devuelve el texto de las opciones del menú según el índice.
    {
        switch (indice)
        {
            case 0:
                return "------------------------------------------------------------------\n" +
                      " > Crear vuelo.                                                   |" +
                      "\n ------------------------------------------------------------------";
            case 1:
                return "------------------------------------------------------------------\n" +
                    " > Reservar un asiento.                                          |" +
                    "\n ------------------------------------------------------------------";
            case 2:
                return "------------------------------------------------------------------\n" +
                    " > Cancelar una reserva.                                         |" +
                    "\n ------------------------------------------------------------------";
            case 3:
                return "------------------------------------------------------------------\n" +
                    " > Mostrar estado actual del vuelo.                               |" +
                    "\n ------------------------------------------------------------------";
            case 4:
                return "------------------------------------------------------------------\n" +
                    " > Mostrar cantidad de asientos disponibles y ocupados del vuelo. |" +
                    "\n ------------------------------------------------------------------";
            case 5:
                return "------------------------------------------------------------------\n" +
                    " > Buscar un asiento en particular y mostrar si esta disponible.  |" +
                    "\n ------------------------------------------------------------------";
            case 6:
                return "------------------------------------------------------------------\n" +
                    " > Salir del sistema.                                             |" +
                    "\n ------------------------------------------------------------------";
            default:
                return "";
        }
    }

    static void EsperarYVolverAlMenu() // Espera que el usuario presione 'M' para volver al menú.
    {
        ConsoleKeyInfo volverMenu;
        bool volverValido = false;
        while (volverValido != true)
        {
            Console.WriteLine("\nPresiona 'M' para volver al menú.");
            volverMenu = Console.ReadKey(true);

            if (volverMenu.Key == ConsoleKey.M)
            {
                volverValido = true;
            }
        }
        Menú(); // Volver al menú principal
    }

    static int[][] Vuelo()
    {
        int opcionVuelo = 0;
        Console.Clear();
        Console.WriteLine("A donde desea viajar: ");

        Console.WriteLine("\n1. París \n2. Nueva York \n3. Tokio \n4. Sídney \n5. Roma");
        {
            Console.Write("\nIngresa el número de la opción: ");
            opcionVuelo = int.Parse(Console.ReadLine());

            switch (opcionVuelo)
            {
                case 1:
                    Console.WriteLine("El vuelo a París ha sido creado. Su vuelo cuenta con 10 filas, con 6 asientos cada una.");
                    break;
                case 2:
                    Console.WriteLine("El viaje a Nueva York ha sido creado. Su vuelo cuenta con 10 filas, con 6 asientos cada una.");
                    break;
                case 3:
                    Console.WriteLine("El viaje a Tokio ha sido creado. Su vuelo cuenta con 10 filas, con 6 asientos cada una.");
                    break;
                case 4:
                    Console.WriteLine("El viaje a Sídney ha sido creado. Su vuelo cuenta con 10 filas, con 6 asientos cada una.");
                    break;
                case 5:
                    Console.WriteLine("El viaje a Roma ha sido creado. Su vuelo cuenta con 10 filas, con 6 asientos cada una.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Elija otra opción.");
                    break;
            }
        }

        int[][] asientos = new int[10][];
        for(int i =  0; i < asientos.Length; i++)
        {
            asientos[i] = new int[6];
        }
        for (int i = 0; i < asientos.Length; i++)
        {
            for (int j = 0; j < asientos[i].Length; j++)
            {
                asientos[i][j] = 0; 
            }
            
        }
        vueloCreado = true;
        return asientos;
    }

    static void ReservarAsiento()
    {
        asientoDesocupado = false;
        while(asientoDesocupado == false)
        {
            Console.Clear();
            int fila = -1;
            int asiento = -1;
            while (fila > 9 || fila < 0)
            {
                Console.Write($"Escriba fila en la que desea viajar: ");
                fila = int.Parse(Console.ReadLine()) - 1;
                if (fila > 9 || fila < 0)
                {
                    Console.WriteLine("\nElija una fila válida, recuerde que el avión cuenta con 10 filas de asientos.");
                }
                else
                {
                    Console.Write("\nEscriba la columna en la que desea viajar: ");
                    asiento = int.Parse(Console.ReadLine()) - 1;
                    if (asiento > 5 || asiento < 0)
                    {
                        Console.WriteLine("\nElija una columna válida, recuerde que cada fila cuenta con 6 asientos.");

                    }
                       
                    if (asientos[fila][asiento] == 1)  // Si el asiento ya está reservado
                    {
                        Console.WriteLine("\nEl asiento elegido ya está reservado. Por favor, elija otro.");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();  // Esperar a que el usuario presione una tecla para continuar
                    }
                       
                    else
                    {
                         asientos[fila][asiento] = 1;
                         Console.WriteLine($"\n Su asiento ha sido reservado. Su asiento es el F{fila + 1}A{asiento + 1}.");
                         asientoReservado = true;
                         asientoDesocupado = true;
                    }

                    
                }
            }
            
            
        }
    }
            

    }
