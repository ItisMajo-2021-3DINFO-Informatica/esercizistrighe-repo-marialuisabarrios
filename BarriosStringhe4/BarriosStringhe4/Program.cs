using System;

namespace BarriosStringhe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int corte=0, medie=0, lunghe=0;
            string parola = "";
            while (parola!="fine")
            {
                Console.WriteLine("inserisci una frase o una parola ");
                parola = Console.ReadLine();
                int lung = parola.Length;
                if (lung<4)
                {
                    corte++;
                }
                else if (lung<=7)
                {
                    medie++;
                }
                else
                {
                    lung++;
                }
            }
            Console.WriteLine($" le parole minori di 4 lettere sono {corte}");
            Console.WriteLine($"le parole con un numero di lettere minore o uguale a 7 sono {medie + corte}");
            Console.WriteLine($"le parole composte da più di 7 lettere sono {lunghe}");

        }
    }
}
