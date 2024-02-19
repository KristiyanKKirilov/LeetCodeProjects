using System;

namespace LongestSubstringWithoutRepating
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = LengthOfLongestSubstring(input);
            Console.WriteLine(count);
        }

        static int LengthOfLongestSubstring(string input)
        {
             if (input == "")
                {
                return 0;
            }
            else if (input == " ")
            {
                return 1;
            }
            else if (input.Length == 1)
            {
                return 1;
            }
            List<string> strings = new();
            List<char> chars = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {

                if (!chars.Contains(input[i]))
                {
                    chars.Add(input[i]);

                    if (i == input.Length - 1)
                    {
                        string currentWord = new(chars.ToArray());
                        strings.Add(currentWord);
                    }
                }
                else
                {
                    char duplicatedChar = input[i];
                    string currentWord = new(chars.ToArray());
                    strings.Add(currentWord);
                    chars = new();
                    int j = i;
                    while (input[j - 1] != duplicatedChar)
                    {
                        chars.Add(input[j - 1]);

                        j--;
                    }                       
                    chars.Add(input[i]);
                }


            }
            return strings.OrderByDescending(s => s.Length)
                .First().Length;
        }
    }
}