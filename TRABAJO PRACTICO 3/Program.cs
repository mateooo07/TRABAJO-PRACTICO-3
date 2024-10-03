using System;

class TrabajoPractico3
{
    
    static void Main()
    {
        Inicio();
        Menú();
        int[][] asientos = Vuelo();
    } 

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

    static void Menú()//Función correspondiente al menu principal del programa.
    {
        int opcion = -1;
        ConsoleKeyInfo Flecha;
        Console.CursorVisible = false;
        do
        {

            Console.Clear();
            Console.WriteLine("----------");
            Console.WriteLine("|| MENÚ ||") ;
            Console.WriteLine("----------\n");
     
            for (int i = 0; i <= 6; i++)
            {
                if (opcion == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // Cambia el color de la opcion seleccionada.
                    Console.WriteLine($"{MenuNumeros(i)}");
                    Console.ResetColor(); // Restaurar al color original.
                }
                else
                {
                    // Mostrar las otras opciones en el color normal.
                    Console.WriteLine($" {MenuNumeros(i)}");
                }
            }

            Flecha = Console.ReadKey(true);

            if (Flecha.Key == ConsoleKey.UpArrow && opcion > 0) opcion--;
            if (Flecha.Key == ConsoleKey.DownArrow && opcion < 6) opcion++;


        } while (Flecha.Key != ConsoleKey.Enter);


        switch (opcion)
        {
        }    
    }

    static string MenuNumeros(int indice)// Devuelve el texto de las opciones del menú según el índice.
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

    static void EsperarYVolverAlMenu()// Espera que el usuario presione 'M' para volver al menú.
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
            else
            {
                volverValido = false;
            }
        }
        Menú();
    }

    static int[][] Vuelo()
    {
        int[][] asientos = new int[10][];
        for(int i =  0; i < asientos.Length; i++)
        {
            asientos[i] = new int[6];
        }
        for (int i = 0; i < asientos.Length; i++)
        {
            for (int j = 0; j < asientos[i].Length; j++)
            {
                asientos[i][j] = 0;  // Todos los asientos están inicialmente libres
            }
        }
        return asientos;
    }
   


}