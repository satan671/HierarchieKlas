using System;
using System.Linq;

namespace Kolos_3
{
    class Program
    {
        static double KtoraKolumna(int[,] a)
        {
            double[] srednia = new double[5];

            for (int i = 0; i < 5; i++)
            {
                srednia[i] = 0;
                for (int j = 0; j < 4; j++)
                {
                    srednia[i] += a[i, j];
                }

                srednia[i] /= 4;
            }
            int nrKolumny = Array.IndexOf(srednia, srednia.Max());

            return nrKolumny;
        }
        static void Main(string[] args)
        {
            int[,] a = new int[5, 4] { { 1, 1, 1, 0 }, { -2, -3, 2, 1 }, { 2, -5, 0, -1 }, { -3, 4, 6, 2 }, { -6, 6, 3, 4 } };

            Console.WriteLine("numer kolumny z maksymalną sumą = " + KtoraKolumna(a));
        }
    }
}