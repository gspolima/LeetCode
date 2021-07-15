using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var array = new int[4] { 2, 11, 7 ,15 };
            var results = solution.TwoSum(array, 9);

            Console.WriteLine("Indexes:");

            foreach (var index in results)
            {
                Console.WriteLine(index);
            }
        }
    }
}
