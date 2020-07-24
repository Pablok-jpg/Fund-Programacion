using System;

namespace switchContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato (Dependiente/Independiente): ");
            string contrato = Console.ReadLine();

            int SMLV = 877803;
            double ibc = salario * 0.4;
            if (ibc < SMLV) ibc = SMLV;

            switch (contrato)
            {
                case "Independiente":
                    Console.WriteLine("Cuál es su nivel de riesgo?");

                    double riesgo = double.Parse(Console.ReadLine());
                    double pensión = ibc * 0.16;
                    double eps = ibc * 0.125;

                    switch (riesgo)
                    {

                        case 1:
                            double arl = ibc * 0.00522;
                            break;

                        case 2:
                            double arl2 = ibc * 0.01044;
                            break;

                        case 3:
                            double arl3 = ibc * 0.02436;
                            break;

                        case 4:
                            double arl4 = ibc * 0.0435;
                            break;

                        case 5:
                            double arl5 = ibc * 0.0696;

                            break;
                    }
                    double salariomensualInd = (salario - (pensión + eps + riesgo));
                    double salarioanualInd = salariomensualInd * 12;

                    Console.WriteLine("Su salario mensual es: $ " + salariomensualInd + "y su salario anual es: $ " + salarioanualInd);
                    break;

                case "Dependiente":
                    double pensiónDep = ibc * 0.04;
                    double epsDep = ibc * 0.04;
                    double salarioMensual = (salario - pensiónDep - epsDep);
                    double salarioAnual = (salarioMensual * 12) + salario;

                    Console.WriteLine("Su salario mensual es: $ " + salarioMensual + "y su salario anual es: $ " + salarioAnual);

                    break;
            }
        }
    }
}
