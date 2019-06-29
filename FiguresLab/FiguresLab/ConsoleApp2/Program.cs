using System;

namespace Kolos_2
{
    class Program
    {
        static void Stozek(int r, int l) // funkcja stozek
        {
            if (r < 0 || l < 0) // jeśli ktoraś wartość jest ujemna
            {
                throw new ArgumentException("ujemny argument"); // wyrzuć wyjątek
            }
            if (r > l) // jeśli tworząca jest krótsza niż promień (nie da się stworzyć stożka) 
            {
                throw new ArgumentException("obiekt nie istnieje"); // wyrzuć wyjątek
            }
            double h = Math.Sqrt(Math.Pow(l, 2) - Math.Pow(r, 2)); // obliczanie wysokości z twierzenia pitagorasa
            double v = Math.Pow(r, 2) * Math.PI * h * 1 / 3; // wzór na objętość
            double v_min = Math.Floor(v); // zaokrąglanie w dół
            double v_max = Math.Ceiling(v); // zaokrąglanie w górę
            Console.Write(v_min + " " + v_max); // wypisywanie danych
        }
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine(); // odczytaj linię
                string[] inputData = input.Split(' '); // rozbij dane oddzielone spacją
                Stozek(Int32.Parse(inputData[0]), Int32.Parse(inputData[1])); // wywołanie funkcji Stozek i przeparsowanie danych ze string na int
            }
            catch (Exception e) // jeśli wystąpił wyjątek
            {
                Console.Write(e.Message); // wyświetl go
            }
        }
    }
}