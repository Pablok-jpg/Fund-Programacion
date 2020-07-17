using System;

namespace CajaCompensacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            double tarifa = 0;

            if (salario < (2 * 877803))
            {
                tarifa = 3400;
                Console.WriteLine("Usted pertenece a la tarifa A, su cuota moderadora es: " + tarifa);

            }
            else if ((2 * 877803) <= salario && salario <= (351121))
            {
                tarifa = 13500;
                Console.WriteLine("Usted pertenece a la tarifa B, su cuota moderadora es: " + tarifa);
            }
            else
            {
                tarifa = 35600;
                Console.WriteLine("Usted pertenece a la tarifa C, su cuota moderadora es: " + tarifa);
            }
        }
    }
}