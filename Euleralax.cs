using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallemos el valor de euler ^x, ingrese x: ");
            double x = double.Parse(Console.ReadLine());
            double e = 0;
            int n = 100;

            for(int i =0; i<n; i++){
                e += (Math.Pow(x, i)) / Factorial(i);
            }
            Console.WriteLine("e^x = " + e);
        }
        static double Factorial(double i){
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }
    }
}
