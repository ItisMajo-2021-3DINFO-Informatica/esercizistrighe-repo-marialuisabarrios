using System;

namespace esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scrivi un programma che, inserita una sequenza di parole, calcoli quante, fra le parole
            //   inserite, iniziano e terminano con la stessa lettera;
            int contaparola = 0;
            string parola = "";
            while (parola!="fine")
            {
                Console.WriteLine("inserisci una parola");
                parola = Console.ReadLine();
                
                char primalettera = parola[0];
                int lungh=parola.Length;
                char ultimalettera =parola[lungh-1];
                if (primalettera == ultimalettera) 
                {
                    contaparola++;
                }
            }
            Console.WriteLine($"il n delle parole che iniziano e fiscano la stssa lettera è di {contaparola}");
        }
    }
}
