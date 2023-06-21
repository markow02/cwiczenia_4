using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_sortowanie_wstawianie
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

            SortowaniePrzezWstawianie(tablica);

            Console.WriteLine("Tablica po sortowaniu:");
            WyswietlTablice(tablica);

            Console.ReadLine();
        }

        static void SortowaniePrzezWstawianie(int[] tablica)
        {
            int n = tablica.Length;
            for (int i = 1; i < n; i++)
            {
                int klucz = tablica[i]; // Aktualny element, który zostanie wstawiony na odpowiednie miejsce
                int j = i - 1;

                while (j >= 0 && tablica[j] > klucz)
                {
                    tablica[j + 1] = tablica[j];
                    j--;
                }

                tablica[j + 1] = klucz; // Wstawienie klucza na odpowiednie miejsce
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
