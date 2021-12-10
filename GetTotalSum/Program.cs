using System;

namespace GetTotalSum
{
    class Program
    {
        //napisz funkcję GetTotal() tak, by sumowała parzyste wartości otrzymywane z funkcji GetNewValue()
        //by otrzymać jak najmniejszą sumę, ale nie mniejszą, niż 5000
        //otrzymaną sumę wyświetl w oknie konsoli
        static void Main(string[] args)
        {
            Console.WriteLine(GetTotal());
        }

        public static int GetNewValue(int x)
        {
            x = x + 3;
            return x;
        }

        public static int GetTotal()
        {
            int sum = 0;
            int y = 0;

            while(sum<=5000)
            {
                Console.WriteLine("Podaj liczbę: ");
                y = Convert.ToInt32(Console.ReadLine());
                if (GetNewValue(y) % 2 == 0)
                {
                    sum = sum + GetNewValue(y);
                }
                else continue;

            }
            Console.WriteLine("Najniższa liczba większa od 5000, sumująca zgodnie z warunkiem x = x + 3 to: ");
            return sum;
        }

    }
}
