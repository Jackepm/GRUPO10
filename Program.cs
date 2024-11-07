using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("Menú de desayuno");
            Console.WriteLine("Elige un desayuno:");

     
            Console.WriteLine("1. Tostadas con mermelada");
            Console.WriteLine("2. Avena con frutas");
            Console.WriteLine("3. Café con leche");
            Console.WriteLine("4. Jugos naturales");
            Console.WriteLine("5. Omelette");

        
            Console.Write("Elige una opción (1-5): ");
            int opcion = int.Parse(Console.ReadLine());
          
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has elegido Tostadas con mermelada.");
                    break;
                case 2:
                    Console.WriteLine("Has elegido Avena con frutas.");
                    break;
                case 3:
                    Console.WriteLine("Has elegido Café con leche.");
                    break;
                case 4:
                    Console.WriteLine("Has elegido Jugos naturales.");
                    break;
                case 5:
                    Console.WriteLine("Has elegido Omelette.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor elige un número entre 1 y 5.");
                    break;
            }


            Console.WriteLine("¡Gracias por usar el menú de desayuno!");
            Console.ReadKey();
     
        }
    }
}

