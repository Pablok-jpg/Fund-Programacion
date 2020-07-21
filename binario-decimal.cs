using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, vamos a convertir un numero binario a decimal.");
            Console.WriteLine("Ingrese b4: ");
            int b4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b3: ");
            int b3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b2: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b1: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b0: ");
            int b0 = int.Parse(Console.ReadLine());

            int n = (b0 * 1) + (b1 * 2) + (b2 * 4) + (b3 * 8) + (b4 * 16);
            Console.WriteLine("El numero ingresado corresponde a: "+n);

        }
    }
}
