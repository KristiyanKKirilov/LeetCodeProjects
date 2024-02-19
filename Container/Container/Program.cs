namespace Container
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while(left < right)
            {
                int currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine(maxArea);

        }
    }
}