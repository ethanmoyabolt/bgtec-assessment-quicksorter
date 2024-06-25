using System;

namespace QuickSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSortFunction QuickSorter = new QuickSortFunction();
            Console.WriteLine("Please enter 10 numbers, they can be integers or decimals, please seperate each input with a comma");
            string[] answer = Console.ReadLine().Split(",");
            double[] numlist = new double[answer.Length];

            for(int i = 0;i < answer.Length - 1; i++)
            {
                numlist[i] = double.Parse(answer[i]);
            }

            QuickSorter.QuickSorter(numlist, 0, numlist.Length - 1);

            Console.WriteLine("Original input: " + string.Join(", ", answer));
            Console.WriteLine("Sorted array: " + string.Join(", ", numlist));

        }
    }
}
