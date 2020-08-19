using System;

namespace Seno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallemos el valor del Seno, ingrese x: ");
            double x = double.Parse(Console.ReadLine());
            double sen = 0;
            int n = 100;

            for (int i = 0; i < n; i++){
                double variable = (2 * i + 1);
                sen += (Math.Pow((-1), i)) / (Factorial(variable)) * Math.Pow(x, variable);
            }
            Console.WriteLine("Sen de x = " + sen);
        }
        static double Factorial(double i){
            if (i <= 1) return 1;
            return i * Factorial(i - 1);
        }
    }
}
