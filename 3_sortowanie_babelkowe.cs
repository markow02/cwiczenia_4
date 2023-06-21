using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_sortowanie_babelkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tablica = new int[10];

            Random rand = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = rand.Next(1, 100);
            }

            Console.WriteLine("Tablica przed sortowaniem:");
            WyswietlTablice(tablica);

            SortowanieBabelkowe(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WyswietlTablice(tablica);

            Console.ReadLine();
        }
        static void SortowanieBabelkowe(int[] tablica)
        {
            int n = tablica.Length;
            bool zamiana; // Flaga wskazująca, czy wystąpiła zamiana elementów

            do
            {
                zamiana = false; 
                for (int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        ZamienElementy(tablica, i, i + 1);
                        zamiana = true;
                    }
                }
                n--; // Zmniejszenie długości tablicy o 1, ponieważ największy element zostaje umieszczony na końcu
            } while (zamiana);
        }

        static void ZamienElementy(int[] tablica, int indeksA, int indeksB)
        {
            int temp = tablica[indeksA];
            tablica[indeksA] = tablica[indeksB];
            tablica[indeksB] = temp;
        }

        static void WyswietlTablice(int[] tablica)
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
