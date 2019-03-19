using System;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrNum = {
                {236, 553, 1376, 420},
                {574, 677, 216, 634},
                {347, 974, 535, 86},
                {1389, 438, 1064, 645}
            };
            Console.WriteLine(String.Join(", ", LargestNumbers(arrNum)));
        }

        static int[] LargestNumbers(int[,] arr)
        {
            int[] results = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int largestNumber = arr[i, 0];
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if(arr[i,j] > largestNumber)
                    {
                        largestNumber = arr[i, j];
                    }
                }
                results[i] = largestNumber;
            }
            return results;
        }
    }
}
