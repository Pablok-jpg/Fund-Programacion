using System;

namespace CajaCompensacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());

            if (salario < (2 * 877803))
            {
                Console.WriteLine("Usted pertenece a la tarifa A.");
            }
            else if ((2 * 877803) <= salario && salario <= (351121))
            {
                Console.WriteLine("Usted pertenece a la tarifa B.");
            }
            else
            {
                Console.WriteLine("Usted pertenece a la tarifa C.");
            }
        }
    }
}
