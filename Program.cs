using System;
using static System.Math;

namespace Find_greater_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program losuje pięć liczb z przedziału 0 - 100 i przedstawia największą.");

           int max = 1, number;

            Random rnd = new Random();
            for (int i = 1; i <= 5; i++)
            {
                number = rnd.Next(0, 100);
                Console.WriteLine("Wylosowana liczba: {0}", number);
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine("Najwieksza liczba ze zbioru wylosowanych to jest: {0}", max);
        }
    }
}
