
int[] heights = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

List<int> sums = new();
int highestSum = 0;
for (int i = 0; i < heights.Length / 2; i++)
{
    //Find first and last height sum
    int first = heights[i];
    int last = heights[heights.Length - (i + 1)];
    int firstSum = first > last ? first * heights.Length : last * heights.Length;
    //Find second and before last height sum
    int second = heights[i + 1];
    int beforeLast = heights[heights.Length - (i + 2)];
    int secondSum = second > beforeLast ? second * heights.Length : beforeLast * heights.Length;
    //Find first and before last sum
    int thirdSum = first > beforeLast ? first * heights.Length : beforeLast * heights.Length;
    //Find second and last
    int fourthSum = second > last ? second * heights.Length : last * heights.Length;
     int[] sumArr = new int[firstSum, secondSum, thirdSum , fourthSum];
    highestSum = sumArr.
}



int firstSum = firstHeight
for (int i = 0; i < heightOfLenghts.Length; i++)
{
    if (heightOfLenghts[i] >= firstHeight)
    {
        secondHeight = heightOfLenghts[i];
        secondHeightIndex = i;
    }
}

for (int i = heightOfLenghts.Length - 1; i >= 0; i--)
{
    if (heightOfLenghts[i] >= secondHeight)
    {
        firstHeight = heightOfLenghts[i];
        firstHeightIndex = i;
    }
}


int range = Math.Abs(firstHeightIndex - secondHeightIndex);
if (firstHeight > secondHeight)
{

    Console.WriteLine(secondHeight * range);
}
else
{
    Console.WriteLine(firstHeight * range);
}

