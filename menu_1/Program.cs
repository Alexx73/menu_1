using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace menu_1
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WindowWidth = 80; // Ancho de la ventana en caracteres
        Console.WindowHeight = 20; // Alto de la ventana en líneas
            // Obtiene el ancho de la consola
        int consoleWidth = Console.WindowWidth;

        // Calcula la posición horizontal para centrar el menú
        int menuWidth = 20; // Anchura del menú
        int leftMargin = (consoleWidth - menuWidth) / 2;

        // Establece la posición del cursor para centrar el menú
        Console.SetCursorPosition(leftMargin, Console.CursorTop);
            int opcion_ingresada;
            opcion_ingresada = 0;

            do
            {
                opcion_ingresada = Menu();
                Console.CursorVisible = false;
                Thread.Sleep(200);
                Console.CursorVisible = true;

                switch (opcion_ingresada)
                {
                    case 1:
                        Console.WriteLine("1. Opción 1");
                        Console.ReadKey();

                        break;
                    case 2:
                        Console.WriteLine("opcion 2");
                        Console.ReadKey();

                        break;
                    case 3:
                        Console.WriteLine("Salir");
                        Console.ReadKey();
                        break;

                    
                    
                }
               
            }
            while (opcion_ingresada != 3);


        }

        static public int Menu()
        {
            int operacion;

            int paddingTop = 5;

              // Obtiene el ancho de la consola
             

        int consoleWidth = Console.WindowWidth;

        // Calcula la posición horizontal para centrar el menú
        int menuWidth = 20; // Anchura del menú
        int leftMargin = (consoleWidth - menuWidth) / 2;

        // Establece la posición del cursor para centrar el menú
        Console.SetCursorPosition(leftMargin, Console.CursorTop);
        Console.Clear();
            for (int i = 0; i < paddingTop; i++)
        {
            Console.WriteLine();
        }


        Console.WriteLine("".PadLeft(leftMargin) + "=== Submenú ===");

            Console.WriteLine("".PadLeft(leftMargin) + "1. Opción 1");
        Console.WriteLine("".PadLeft(leftMargin) + "2. Opción 2");
        Console.WriteLine("".PadLeft(leftMargin) + "3. Salir");
        
            Console.WriteLine("".PadLeft(leftMargin) +"================");
            Console.Write("".PadLeft(leftMargin) +"Ingrese opción: ");
            operacion = Convert.ToInt32(Console.ReadLine());      
            if (operacion < 1 || operacion >4)
            { 
            Console.WriteLine("".PadLeft(leftMargin) +"opcion invalida");
            Thread.Sleep(1000);
            }
            Console.Clear();
            return operacion;
        }
    }
}
