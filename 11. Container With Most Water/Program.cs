using System;

namespace _11._Container_With_Most_Water
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heightOfLenghts = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int secondHeight = heightOfLenghts[0];
            int firstHeight = 0;


            for (int i = 0; i < heightOfLenghts.Length; i++)
            {
                if (heightOfLenghts[i] >= firstHeight)
                {
                    secondHeight = heightOfLenghts[i];
                }
            }

            for (int i = heightOfLenghts.Length - 1; i >= 0; i--)
            {
                if (heightOfLenghts[i] >= secondHeight)
                {
                    firstHeight = heightOfLenghts[i];
                }
            }

            Console.WriteLine(firstHeight * secondHeight);
        }
    }
}