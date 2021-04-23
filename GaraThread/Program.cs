using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
            for(int c = 0; c < n; c++)
            {
                int toPass = c;
                Thread IniziaCorsa = new Thread(() => Corsa(nomi[toPass])); 
                IniziaCorsa.Start();
            }
            Console.ReadLine();
        }

        private static async Task Corsa(string nome)
        {
            await Task.Run(() =>
            {
                for (int c = 1; c < 100; c++)
                {
                    Console.WriteLine($"{nome} è al km {c}.");
                }
                Console.WriteLine($"{nome} è al km 100, è arrivato");
            });
            
        }
    }
}
