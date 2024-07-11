using System;

namespace JulyLeetCodeExercises
{
	public class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string w = n.ToString();
			string r = new (w.Reverse().ToArray());
			if(r == w)
			{
                Console.WriteLine(true);
            }
			else
			{
				Console.WriteLine(false);
			}

        }
	}
}