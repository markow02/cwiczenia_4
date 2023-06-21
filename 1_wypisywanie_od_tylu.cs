using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_wypisywanie_od_tylu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];

            Random rand = new Random();
            Console.WriteLine("Zawartość tablicy:");
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(1, 100);
                Console.Write(tablica[i] + " ");
            }
            
            Console.WriteLine("\n\nZawartość tablicy od tyłu:");
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
