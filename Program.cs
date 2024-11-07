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

        }
    }
}

