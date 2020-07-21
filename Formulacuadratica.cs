using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculemos la fórmula cuadrática.");
            Console.WriteLine("Ingrese a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c: ");
            double c = double.Parse(Console.ReadLine());

            double disc = (Math.Pow(b, 2)) - 4 * (a * c);
            double x1 = 0;
            double x2 = 0;

            if (disc == 0){
                x1 = ((-b) / (2 * a));
                Console.WriteLine("X= " + x1);
            }
            else if (disc > 0){
                x1 = -b + (disc) / (2 * a);
                x2 = -b - (disc) / (2 * a);
                Console.WriteLine("X1= " + x1);
                Console.WriteLine("X2= " + x2);
            }
            else{
                Console.WriteLine("No tiene solucion.");
            }
        }
    }
}
