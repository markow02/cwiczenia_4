using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_sortowanie_wybieranie
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

            SortowaniePrzezWybieranie(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WyswietlTablice(tablica);

            Console.ReadLine();
        }

        static void SortowaniePrzezWybieranie(int[] tablica)
        {
            int n = tablica.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i; //Indeks aktualnego elementu

                // Szukanie najmniejszego elementu w pozostałej części tablicy
                for (int j = i + 1; j < n; j++)
                {
                    if (tablica[j] < tablica[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Zamiana miejscami elementu na pozycji i z najmniejszym elementem
                int temp = tablica[i];
                tablica[i] = tablica[minIndex];
                tablica[minIndex] = temp;
            }
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
