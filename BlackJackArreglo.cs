using System;

namespace asddcf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos jugadores son? : (máximo 5, mínimo 2)");
            int jugadores = int.Parse(Console.ReadLine());
            string[] nombres = new string[jugadores];
            int[] total = new int[jugadores];

            while (jugadores < 2 || jugadores > 5){
                Console.WriteLine("Los jugadores tienen que ser mínimo 2 y máximo 5. Ingrese de nuevo su respuesta");
                jugadores = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < jugadores; i++) {
                Console.WriteLine("Ingrese el nombre: ");
                nombres[i] = Console.ReadLine();
                Random aleatorio = new Random();
                Console.WriteLine("Empieza el jugador " + nombres[i]);
                int carta1 = aleatorio.Next(1, 11);
                int carta2 = aleatorio.Next(1, 11);
                total[i] = carta1 + carta2;
                Console.WriteLine("Su carta 1 fue: " + carta1);
                Console.WriteLine("Su carta 2 fue: " + carta2);
                Console.WriteLine("Su total es: " + total[i] + " puntos.");

                string respuesta = "s";
                while (total[i] < 21 && respuesta == "s")
                {
                    Console.WriteLine("¿Desea continuar? s/n");
                    respuesta = Console.ReadLine();
                    while (respuesta != "s" && respuesta != "n"){
                        Console.WriteLine("Respuesta no valida, porfavor ingrese de nuevo su respuesta: s/n");
                        respuesta = Console.ReadLine();
                    }
                    if (respuesta == "n") break;
                    else{
                        int carta = aleatorio.Next(1, 11);
                        total[i] += carta;
                        Console.WriteLine("Su nueva carta es: " + carta);
                        Console.WriteLine("Su total es: " + total[i] + " puntos.");
                    }
                }
                if (total[i] <= 21){
                    Console.WriteLine("Terminó el juego con un total de: " + total[i]);
                }
                else{
                    Console.WriteLine("Queda eliminado, con un total de: " + total[i]);
                    total[i] = 0;
                }
            }
            for (int j = 0; j < jugadores; j++){
                for (int k = 0; k < jugadores - 1; k++){
                    if (total[k] < total[k + 1]){
                        int tmp = total[k];
                        total[k] = total[k + 1];
                        total[k + 1] = tmp;
                        string tmpN = nombres[k];
                        nombres[k] = nombres[k + 1];
                        nombres[k + 1] = tmpN;
                    }
                }
            }
            Console.WriteLine("El primer puesto es para: " + nombres[0] + " con un total de: " + total[0] + " puntos," + " y el segundo puesto es para: " + nombres[1] + " con un total de: " + total[1] + " puntos.");
        }
    }
}