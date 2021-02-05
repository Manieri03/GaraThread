using System;
using System.Collections.Generic;
using System.Threading;

namespace GaraThread
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomi = new List<string>();
            Console.Write("Scrivi qui il numero dei partecipanti: ");
            int n = int.Parse(Console.ReadLine());
            for (int c = 1; c <= n; c++)
            {
                Console.WriteLine($"Partecipante n.{c}: ");
                string nome = Console.ReadLine();
                nomi.Add(nome);               
            }
            for(int c = 1; c <= n; c++)
            {
                Thread IniziaCorsa = new Thread(() => Corsa(nomi[c]));
                IniziaCorsa.Start();
            }
            Console.ReadLine();
        }

        private static void Corsa(string nome)
        {
            for (int c = 1; c < 100; c++)
            {
                Console.WriteLine($"{nome} è al km {c}.");
            }
            Console.WriteLine($"{nome} è al km 100, è il vincitore!");
        }
    }
}
