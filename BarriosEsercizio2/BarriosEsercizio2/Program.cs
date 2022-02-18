using System;

namespace BarriosEsercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Scrivi un programma che, inserita una sequenza di parole, calcoli la media della lunghezza
            //  delle parole con meno di otto caratteri e la media della lunghezza delle parole con almeno
            //  otto caratteri;
            int contalunghe = 0;
            int contacorte = 0;
            string parola = "";
            int sommacorte = 0;
            int sommalunghe = 0;
            int medialunghe=0, mediacorte=0;
            while (parola != "fine")
            {
                Console.WriteLine("inserisci una parola");
                parola = Console.ReadLine();
                int lunghezza=parola.Length;  
                if (lunghezza<8)
                {
                    sommacorte = sommacorte + lunghezza;
                    contacorte++;
                }
                else
                {
                    sommalunghe = sommalunghe + lunghezza;
                    contalunghe++;
                }
            }
            mediacorte = sommacorte / contacorte;
            medialunghe = sommalunghe / contalunghe;
            Console.WriteLine($"lam media della lunghezzadelle parole con meno di 8 lettere è{mediacorte}");
            Console.WriteLine($"la media della lunghezza delle parole con almeno di 8 lettere è{medialunghe}");
        }
    }
}
