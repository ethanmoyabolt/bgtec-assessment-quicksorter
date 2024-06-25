using System;
using Xunit;
using QuickSorter;
using FluentAssertions;

namespace QuickSorter.Tests
{
    public class QuickSortFunctionTests
    {
        [Fact]
        public void QuickSortFunction_QuickSorter_WhenUnsortedIntegerArray_ReturnSortedArray()
        {
            // Arrange
            double[] testArray = { 9, 2, 3, 4, 8, 6 };
            double[] expected = { 2, 3, 4, 6, 8, 9};
            QuickSortFunction quickSorter = new QuickSortFunction();

            // Act
            quickSorter.QuickSorter(testArray, 0, testArray.Length - 1);
            double[] result = testArray;

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void QuickSortFunction_QuickSorter_WhenUnsortedDoubleArray_ReturnSortedArray()
        {
            // Arrange
            double[] testArray = { 9.8, 2.4, 2.3, 4.7, 8.5, 6.3 };
            double[] expected = { 2.3, 2.4, 4.7, 6.3, 8.5, 9.8 };
            QuickSortFunction quickSorter = new QuickSortFunction();

            // Act
            quickSorter.QuickSorter(testArray, 0, testArray.Length - 1);
            double[] result = testArray;

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void QuickSortFunction_QuickSorter_WhenUnsortedIntegerArrayWithTwoIdenticalValues_ReturnSortedArray()
        {
            // Arrange
            double[] testArray = { 9, 2, 2, 4, 8, 6 };
            double[] expected = { 2, 2, 4, 6, 8, 9 };
            QuickSortFunction quickSorter = new QuickSortFunction();

            // Act
            quickSorter.QuickSorter(testArray, 0, testArray.Length - 1);
            double[] result = testArray;

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
