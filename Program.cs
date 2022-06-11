using System;

namespace Wordle

{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palabrasAdinar = { "ARBOL", "PEINE", "COSTA", "DOLAR", "MOUSE", };
            string palabraAleatoria;
            string palabraJugador = "";
            int intentos = 1;
            Random random = new Random();

            palabraAleatoria = palabrasAdinar[random.Next(palabrasAdinar.Length)];
            Console.WriteLine($"{palabraAleatoria}");
            
            Console.WriteLine("Comienza una nueva partida de WORDLE Consola");
            do
            {
                Console.WriteLine($"Intento #{intentos}");
                Console.WriteLine("Adivina la palabara de 5 letras: ");
                string palabraTeclado = Console.ReadLine();
                palabraJugador = palabraTeclado.ToUpper();
                string[] relleno = { "_", "_", "_", "_", "_", "_", };
                if (palabraAleatoria == palabraJugador)
                {
                    Console.WriteLine($"Felicitaciones, adivinaste la palabara en {intentos} intentos");
                    break;
                }
                for (int i = 0; i < palabraAleatoria.Length; i++)
                {
                    if (palabraAleatoria.Substring(i) == palabraJugador.Substring(i))
                    {
                        char letraAcertada = palabraAleatoria[i];
                        Console.WriteLine($"Acertaste las siguientes letras {letraAcertada} en la posición correcta {relleno[i+1]}");
                    }
                    else
                    {
                        char letraNoAcertada = palabraJugador[i];
                        Console.WriteLine($"Acertaste las siguientes letras {letraNoAcertada} pero no la palabra completa ");
                    }
                }


                intentos++;
                
            } while (!(palabraJugador == "?"));


        }
    }

}

