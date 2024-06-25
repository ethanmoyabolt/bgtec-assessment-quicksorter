using System;

namespace QuickSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            QuickSortFunction QuickSorter = new QuickSortFunction();

            // Use this to allow the console to get inputs repeatedly
            bool again = true;


            while (again)
            {
                Console.WriteLine("Please enter 10 numbers, they can be integers or decimals, please seperate each input with a space");
                Console.WriteLine("Enter 'x' to close");
                string answer = Console.ReadLine();

                if (answer == "x")
                {
                    again = false;
                }

                else
                {
                    // Split the provided numbers
                    string[] unsortedList = answer.Split(" ");
                    bool error = false;

                    // Specification requests a maximum of 10 numbers inputted
                    if (unsortedList.Length > 10)
                    {
                        Console.WriteLine("Please only enter 10 numbers");
                    }
                    else
                    {
                        double[] numlist = new double[unsortedList.Length];

                        for (int i = 0; i < unsortedList.Length; i++)
                        {
                            if (double.TryParse(unsortedList[i], out double num))
                            {
                                numlist[i] = num;
                            }
                            else
                            {
                                // Error handles if a non integer/ double is passed through
                                Console.WriteLine("Please make sure all entries are numbers and there is 1 space between each input");
                                error = true;
                                break;
                            }
                        }

                        if (!error)
                        {

                            QuickSorter.QuickSorter(numlist, 0, numlist.Length - 1);

                            Console.WriteLine("Original input: " + string.Join(", ", unsortedList));
                            Console.WriteLine("Sorted array: " + string.Join(", ", numlist));
                        } 
                    }

                } 
            }

        }
    }
}
