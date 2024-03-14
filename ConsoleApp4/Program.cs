using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        public static void DrawSquare(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            List<int> result = new List<int>();

            foreach (int num in originalArray)
            {
                if (!filterArray.Contains(num))
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            //Задание 1
            int squareLength = 5;
            char squareSymbol = '*';
            DrawSquare(squareLength, squareSymbol);

            //Задание 2

            int number = 1221;
            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine(isPalindrome);

            //Задание 3
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] filteredArray = FilterArray(originalArray, filterArray);
            Console.WriteLine(string.Join(" ", filteredArray)); 


        }
    }
}
