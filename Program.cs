using System;
using System.Collections.Generic;
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

        public static string GetMiddle(string s)
        {
            var stringLength = s.Length;
            int middle = stringLength / 2;
            var middleChar = s[middle];

            if (stringLength % 2 != 0)
            {
                Console.WriteLine(Char.ToString(middleChar));
                return Char.ToString(middleChar);

            }
            else
            {
                return s.Substring(middle - 1, +2);
            }
        }

        public static int Find(int[] integers)
        {
            var countOfEvens = integers.Count(n => n % 2 == 0);
            var countOfOdds = integers.Count(n => n % 2 == 1);

            if (countOfEvens > countOfOdds)
            {
                return integers.First(n => n % 2 == 1);
            }
            else
            {
                return integers.First(n => n % 2 == 0);
            }
        }


        public static string Remove_char(string s)
        {
            var removedFirstChar = s.Substring(1);
            return removedFirstChar.Remove(removedFirstChar.Length - 1, 1);


        }

        public static int sumTwoSmallestNumbers(int[] numbers)
        {

            Array.Sort(numbers);
            return numbers[0] + numbers[1];
        }


        public static List<int> RemoveSmallest(List<int> numbers)
        {

            if (numbers.Count > 0)
            {
                numbers.Remove(numbers.Min());
            }

            return numbers;
        }

        static void Main(string[] args)
        {
            DisplayGreeting();

            Console.WriteLine();

            ReversedString("Hello there!");

            ReversedWordsInString("Whats Up My Dude");

            GetMiddle("Heyo");

            Remove_char("Hey there");




        }
    }
}
