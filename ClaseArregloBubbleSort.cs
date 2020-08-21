using System;
using System.Globalization;

namespace Trabajo_autónomo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            for (int J = 0; J < nombres.Length; J++)
            {
                for (int i = 0; i < nombres.Length - 1; i++)
                {
                    if (estatura[i] < estatura[i + 1])
                    {
                        string tpmN = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = tpmN;
                        double tpm = estatura[i];
                        estatura[i] = estatura[i + 1];
                        estatura[i + 1] = tpm;
                    }
                }
            }
            for (int k = 0; k < estatura.Length; k++){
                Console.WriteLine((k + 1) + " " + nombres[k] + " con:" + estatura[k]);
            }
        }
    }
}