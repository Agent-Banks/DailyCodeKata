using System;

namespace DailyCodeKata
{
    class Program
    {
        static void DisplayGreeting()
        {
            Console.WriteLine("Hello!");
        }

        public static int[] MonkeyCount(int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = i + 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            DisplayGreeting();

            Console.WriteLine();

        }
    }
}
