using System;

namespace PalindromeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charInput = input.ToCharArray();

            Array.Reverse(charInput);

            string reverseInput = new string(charInput);

            //Console.WriteLine(reverseInput);
            
            if(input != reverseInput)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}