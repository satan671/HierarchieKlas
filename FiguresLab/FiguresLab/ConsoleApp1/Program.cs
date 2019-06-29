using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos_1
{
    class Program
    {
        static void Star() => Console.Write('*'); // fukcja wyświetlająca gwiazdkę
        static void StarLn() => Console.WriteLine('*'); // funkcja wyświetlająca gwiazdkę i przenosząca napis do nowej linii
        static void Dot() => Console.Write('.'); // funkcja wyswietlajca kropkę
        static void DotLn() => Console.WriteLine('.'); // funkcja wyswietlajca kropkę i przenosząca napis do nowej linii

        #region wzorek A
        static void Wzorek_A(int n, int m) // wzorek A
        {
            if (n % 2 == 0) // jeśli liczba n jest parzysta
                n++; // zwiększ n o jeden

            if (m % 2 == 0) // jeśli liczba m jest parzysta
                m++; // zwiększ m o jeden

            // pierwsza linia
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }

            StarLn();

            // część druga do środka
            for (int i = 0; i < (m - 3) / 2; i++)
            {
                Star();

                for (int j = 0; j < (n - 3) / 2; j++)
                {
                    Dot();
                }

                Star();

                for (int j = 0; j < (n - 3) / 2; j++)
                {
                    Dot();
                }

                StarLn();
            }

            // środkowa linia (taka sama jak pierwsza)
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }

            StarLn();

            // część trzecia do końca (taka sama jak część druga)
            for (int i = 0; i < (m - 3) / 2; i++)
            {
                Star();

                for (int j = 0; j < (n - 3) / 2; j++)
                {
                    Dot();
                }

                Star();

                for (int j = 0; j < (n - 3) / 2; j++)
                {
                    Dot();
                }

                StarLn();
            }

            // środkowa linia (taka sama jak pierwsza)
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }

            StarLn();
        }
        #endregion

        #region wzorek B
        static void Wzorek_B(int n) // wzorek B
        {
            // pierwsza linia
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }

            StarLn();

            // kolejne linie
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Dot();
                }

                Dot();
                Star();

                for (int j = 0; j < n - 3 - i; j++)
                {
                    Dot();
                }

                DotLn();
            }

            // ostatnia linia (taka jak pierwsza)
            for (int i = 0; i < n - 1; i++)
            {
                Star();
            }

            StarLn();
        }
        #endregion
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // odczytaj linię
            string[] inputData = input.Split(' '); // rozbij dane oddzielone spacją

            if (inputData[0] == "A") // jeśli wybrano wzorek A
            {
                Wzorek_A(Int32.Parse(inputData[1]), Int32.Parse(inputData[2])); // wywołanie funkcji Wzorek_A i przeparsowanie danych ze string na int
            }
            else if (inputData[0] == "B") // jeśli wybrano wzorek B
            {
                Wzorek_B(Int32.Parse(inputData[1]));// wywołanie funkcji Wzorek_B i przeparsowanie danych ze string na int
            }
        }
    }
}