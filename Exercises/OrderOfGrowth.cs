using System;
using System.Data;

namespace Exercises
{
    public class OrderOfGrowth
    {
        public static int ConstantGrowth()
        {
            //TC: O(1)
            //This algorithm runs in constant time
            int i = 0;
            int j = 10;
            int total = i + j;
            int mid = total / 2;
            return mid;
        }
        public static int LogarithmGrowth(int[] sortedArray, int target)
        {
            //TC: O(LogN)
            //An algorithm where size of input is halved after every iteration
            //Binary Search
            int i = 0;
            int j = sortedArray.Length - 1;

            while (i <= j)
            {
                //We do this to prevent overflow on large array length
                int mid = i + ((j - i) / 2);
                if (sortedArray[mid] == target)
                {
                    return 1;
                }
                else if (target < sortedArray[mid])
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }
            return 0;
        }
        public static int LinearGrowth()
        {
            //TC: O(N)
            //An algorithm with a simple loop
            //Single loop function
            int total = 0;

            for (int i = 0; i < 10; i++)
            {
                total += 1;
            }

            //if there is two loops and it is not nested
            //You will get a o(2N) time complexity which simplifies to O(N), meaning having two for loops that are not nested is still linear
            for (int k = 0; k < 10; k++)
            {
                total += 1;
            }

            return total;


        }
        public static int[] NLogNGrowth(int[] unsortedArray)
        {
            //TC: O(NLogN)
            //This is usually a divide and conquer method via sorting algorithms
            //here is a merge sort
            
            //Base case
            if (unsortedArray.Length <= 1)
            {
                return unsortedArray;
            }

            //First lets create a midpoint
            int mid = unsortedArray.Length / 2;
            //First lets split our array into two partitions. Lets say our array has a size input of 6
            //Example Array: [5,2,3,1,7,4] = length 7
            int[] leftPartition = new int[mid]; //will equal 3
            int[] rightPartition = new int[unsortedArray.Length - mid]; // will equal 4

            //Copy the first half of unsortedArray to mid for mid number of elements -> to left partition starting at 0 and for (mid number of elements)
            Array.Copy(unsortedArray, 0, leftPartition, 0, mid);

            //Copy the other half of the unsortedArrayt starting at mid and leftPartition.Length - mid number of elements  -> to right partition starting at 0 for leftPartition.Length - mid number of legends
            Array.Copy(unsortedArray, mid, rightPartition, 0, unsortedArray.Length - mid);

            //Recursively go through both halves O(logN)
            int[] sortedLeft = NLogNGrowth(leftPartition);
            int[] sortedRight = NLogNGrowth(rightPartition);

            return Merge(sortedLeft, sortedRight);

        }
        private static int[] Merge(int[] left, int[] right)
        {
            int[] merged = new int[left.Length + right.Length];
            int leftPointer = 0;
            int rightPointer = 0;
            int mergedPointer = 0;

            while (leftPointer < left.Length && rightPointer < right.Length)
            {
                if (left[leftPointer] <= right[rightPointer])
                {
                    merged[mergedPointer++] = left[leftPointer++];
                }
                else
                {
                    merged[mergedPointer++] = right[rightPointer++];
                }
            }

            // Copy any remaining elements from the left array
            while (leftPointer < left.Length)
            {
                merged[mergedPointer++] = left[leftPointer++];
            }

            // Copy any remaining elements from the right array
            while (rightPointer < right.Length)
            {
                merged[mergedPointer++] = right[rightPointer++];
            }

            return merged;
        }
        public static int QuadraticGrowth()
        {
            //TC: O(N^2)
            //Nested for loop
            //For example we have a 10 element input, and we want to find every combination possible. We will be looking at 10!
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    total += 1;
                }
            }
            return total;
        }
        public static int CubicGrowth()
        {
            //TC: O(N^3)
            //Triple Nested for loop
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0;j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        total += 1;
                    }
                }
            }
            return total;
        }
        public static int ExponentialGrowth(int n)
        {
            //TC: 2^N or any constant^2
            //A great example of exponential growth is fibonacci sequence
            //As the input grows it will grow with the power of 2
            if (n < 2)
            {
                return n;
            }
            return ExponentialGrowth(n - 1) + ExponentialGrowth(n - 2);
        }
    }
}
