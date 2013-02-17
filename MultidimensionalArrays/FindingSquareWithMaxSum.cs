//Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class FindingSquareWithMaxSum
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());//col
        int n = int.Parse(Console.ReadLine());//row
        int[,] matrix = new int[n, m];
        for (int inputRow = 0; inputRow < n; inputRow++)
        {
            for (int inputColl = 0; inputColl < m; inputColl++)
            {
                matrix[inputRow, inputColl] = int.Parse(Console.ReadLine());
            }
        }
        int maxSum = int.MinValue;
        int sum = 0;
        int firstColWithMaxSum = 0;
        int firstRowWithMaxSum = 0;

        for (int row = 0; row <= n - 3; row++)
        {
            for (int coll = 0; coll <= m - 3; coll++)
            {//matrix 3x3
                sum = 0;
                for (int r = row; r < row + 3; r++)
                {
                    for (int c = coll; c < coll + 3; c++)
                    {
                        sum += matrix[r, c];
                    }
                }
                if (maxSum < sum)
                {
                    firstColWithMaxSum = coll;
                    firstRowWithMaxSum = row;
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(" The maximal sum is " + maxSum);
        for (int i = firstRowWithMaxSum; i < firstRowWithMaxSum + 3; i++)
        {
            for (int j = firstColWithMaxSum; j < firstColWithMaxSum + 3; j++)
            {
                Console.Write("{0,-4}",matrix[i,j]);
            }
            Console.WriteLine("");
        }
    }
}

