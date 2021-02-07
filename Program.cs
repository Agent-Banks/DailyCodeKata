using System;
using System.Linq;

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

        public static string ReversedString(string str)
        {
            char[] stringArray = str.ToCharArray();
            string reverse = String.Empty;
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }
            Console.WriteLine(reverse);
            return reverse;

        }




        static void Main(string[] args)
        {
            DisplayGreeting();

            Console.WriteLine();

            ReversedString("Hello there!");

        }
    }
}
