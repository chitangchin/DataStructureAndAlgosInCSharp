namespace Exercises
{
    public class TimeComplexity
    {
        public static int TimeComplexityOne()
        {
            /*
             * Practice Primitive Operations: (Constant Execution Time)
             * - Declaration
             * - Assignment
             * - Arithmetic Operations
             * - Comparison Statements
             * - Accessing Elements
             * - Calling Functions
             * - Returning Functions
             */

            //Example n
            int n = 10;

            //Actual Function
            int total = 0; // TC: O(1) + O(1) - Declaration and Assignment
            int i = 1; // TC: O(1) + O(1) - Declaration and Assignment
            while (i <= n) // TC O(1) * (N + 1) - Comparison operation n + 1 because we are iterating until i is greater than n, and + 1 because of the final loop when it is condition false 
            {
                total += i;// TC: O(1) * (N) - Inherits the N times from the while loop
                i++;// TC: O(1) * (N) Inherits the N times from the while loop
            }
            return total;// TC: O(1) - Return function

            /*
             * If you add all the Time complexities:
             * (1) + (1) + (1) + (1) + (N + 1) + (N + N) + (1)
             * (5) + (N + 1) + (N + N)
             * (5) + (3N + 1)
             * 6 + 3N
             * The Theoretical Time Complexity Analysis is: 6 + 3N
             */
        }
        public static int TimeComplexityTwo()
        {
            //Double for loop
            //Data
            int[][] A = [[1, 2, 3], [1, 3, 4], [4, 5, 6]];// TC: 1 + 1 - Declaration and Assignment
            int n = A.Length;// TC: 1 + 1 - Declaration and Assignment
            int m = A[0].Length;// TC: 1 + 1 - Declaration and Assignment
            int total = 0;// TC: 1 + 1 - Declaration and Assignment
                          //Total: 4 declaration and 4 assignments

            //Algorithm
            for (int i = 0; i < n; i++) //TC: 1 + 1 Declaration and Assignment, N + 1 Comparison Operation, N + 1 Increment Operation
            {
                for (int j = 0; j < m; j++) //TC: 1*N + 1*N Declaration and Assignment, N * (M + 1) Comparison Operation, N * (M + 1) Increment Operation
                {
                    total += A[i][j]; //TC: Accessing Array 1 * (n*m), Arithmetic 1 * (n*m)
                }
            }
            /*
             * Total: 4 + 4 + 2 + (N + 1) + (N + 1) + (N + N) + N * (M + 1) + N * (M + 1) + (N * M) + (N * M)
             * Simplified: 12 + 6N + 4N*M
             * Final: 12 + 6N + 4N^2 for a very large N and M
             */

            //Grand Total TC: 4 + N * M
            return total;
        }
        public static int TimeComplexityThree(int[] A, int key)
        {
            //Binary search
            //Data
            int i = 0; //declaratio and assignment 1 + 1
            int j = A.Length; // declaration and assignment 1 + 1

            //Algorithm
            while (i < j) //Logn + 1 because while loop will only iterate through half of the array and repeat this with the another half of the half until it finds the key
            {
                /*
                 * Declaration: Log N
                 * Assignments: Log N
                 * Comparison Operators: Log N
                 * Arithmetic Operations: Log N
                 */
                int mid = (i + j) / 2;// assignment and declaration
                if (A[mid] == key)// comparison operations
                {
                    //Found the number
                    return 1;//return operation 1
                }
                else if (A[mid] > key)// comparison operations
                {
                    j = mid - 1;// assignment and declaration
                }
                else// comparison operations
                {
                    i = mid + 1;// assignment and declaration
                }
            }
            //Did not find the number
            return 0;//return operation 1
            /*
             * Total: 6 + (logN + 1) + 4logN
             * final: 7 + 5LogN
             */
        }

    }
}