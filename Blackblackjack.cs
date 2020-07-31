using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al Blackjack");

            Random aleatorio = new Random();
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int total = carta1 + carta2;
            Console.WriteLine("Carta 1 = " + carta1);
            Console.WriteLine("Carta 2 = " + carta2);
            Console.WriteLine("Total: " + total);
            string continuar = "s";

            while (continuar == "s" && total != 21){
                Console.WriteLine("Desea otra carta?: (s/n): ");
                continuar = Console.ReadLine();
                int carta = aleatorio.Next(1, 7);
                Console.WriteLine("Carta: " + carta);
                total += carta;
                Console.WriteLine("Total: " + total);
                if (total > 21){
                    continuar = "n";
                    Console.WriteLine("Ha sido eliminado");                
                }
            }
        }
    }
}
