using System;

namespace TutoríaIsabella
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Nezuko", "Tanjiro", "Zenitsu", "Inosuke", "Genya", "Kanao", "Tomioka" };
            double[] estatura = { 153, 165, 164.5, 164, 180, 156, 176 };
            double total = 0;
            for (int i = 0; i < nombres.Length; i++){
                total += estatura[i];
            }
            double promedio = total / nombres.Length;
            Console.WriteLine("Promedio: " + promedio + " cm.");
            for (int j = 0; j < estatura.Length; j++){
                double distancia = Math.Abs(promedio - estatura[j]);
                Console.WriteLine( nombres[j] + " : " + estatura[j] + " cm, y la distancia al promedio es: " + distancia + " cm.");
            }
        }
    }
}
