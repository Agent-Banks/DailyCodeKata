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


        public static string ReversedWordsInString(string str)
        {
            var reversedWords = string.Join(" ",
            str.Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine(reversedWords);
            return reversedWords;

            //Split on spaces
            //For each word, create a new word by treating the input as a sequence of characters, reverse that sequence, turn the result into an array, and then call the string(char[]) constructor
            //Depending on framework version, call ToArray() on the string sequence, as .NET 4 has more overloads available
            //Call string.Join on the result to put the reversed words back together again.
        }


        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null)
                nums = new int[0];

            Array.Sort(nums);
            return nums;
        }

        public static int[] NoOdds(int[] values)
        {
            return values.Where(x => x % 2 == 0).ToArray();
        }



        static void Main(string[] args)
        {
            DisplayGreeting();

            Console.WriteLine();

            ReversedString("Hello there!");

            ReversedWordsInString("Whats Up My Dude");

        }
    }
}
