using System;

namespace FirstRelativeSubstring
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split();
          
            string resultWord = inputWords[0];

            string result = string.Empty;
            int indexOfInputWords = 0;

            foreach (string currentWord in inputWords.Skip(1))
            {
                string previousWord = inputWords[indexOfInputWords];

                string shortestWord = FindShortestWord(inputWords);

                for (int i = 0; i < shortestWord.Length; i++)
                {
                    if (currentWord[i] == previousWord[i])
                    {
                        result += currentWord[i];
                    }
                    else
                    {
                        break;
                    }
                }
                
                if (result != resultWord && result.Length < resultWord.Length)
                {
                   resultWord = result;
                }
                result = string.Empty;
                indexOfInputWords++;

            }

            Console.WriteLine(resultWord);
        }

        static string FindShortestWord(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return null; 
            }

            string shortestWord = words[0]; // Assume the first word is the shortest.

            foreach (string word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord = word; 
                }
            }

            return shortestWord;
        }

    }
}