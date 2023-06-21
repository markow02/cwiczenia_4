using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_min_max
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

            int najmniejszy = tablica[0];
            int największy = tablica[0];

            for (int i = 1; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszy)
                {
                    najmniejszy = tablica[i];
                }

                if (tablica[i] > największy)
                {
                    największy = tablica[i];
                }
            }

           
            Console.WriteLine("\n\nNajmniejszy element: " + najmniejszy);
            Console.WriteLine("Największy element: " + największy);
        }
    }
}
