using System;
using System.Linq;

namespace Solution3
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
            return Enumerable.Range(0, arr.GetLength(0))
                .Select(i => Enumerable.Range(0, arr.GetLength(1))
                .Select(j => arr[i, j])
                .Max())
                .ToArray();
        }
    }
}
