using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSorter
{
    public class QuickSortFunction
    {
        public void QuickSorter(double[] numList, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(numList, low, high);

                // Recursively apply QuickSort to the left and right sub-arrays
                QuickSorter(numList, low, pivotIndex - 1);
                QuickSorter(numList, pivotIndex + 1, high);
            }
        }

        private int Partition(double[] numList, int low, int high)
        {
            // Choose the middle element as the pivot as this improves performance
            int mid = low + (high - low) / 2;
            double pivot = numList[mid];

            // Move the pivot to the end temporarily
            Swap(numList, mid, high);

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numList[j] <= pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    Swap(numList, i, j);
                }
            }

            // Move the pivot back to its correct position
            Swap(numList, i + 1, high);

            // Return the index of the pivot
            return i + 1;
        }

        private void Swap(double[] numList, int i, int j)
        {
            double temp = numList[i];
            numList[i] = numList[j];
            numList[j] = temp;
        }
    }
}
