//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S. 
using System;


class SubsetWithSumS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int CheckSum = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int mask;
        int sum;
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int c = 0; c < (Math.Pow(2, n) - 1); c++)
        {
            mask = 1;
            sum = 0;
            count = 0;
            do
            {
                if ((mask & c) == mask)
                {
                    sum += arr[n - 1 - count];
                }
                mask <<= 1;
                count++;
            } while (mask <= c);
            if (CheckSum == sum)
            {
                Console.WriteLine("Yes");
                mask = 1;
                count = 0;
                do
                {
                    if ((mask & c) == mask)
                    {
                        Console.WriteLine(arr[n - 1 - count]);
                    }
                    mask <<= 1;
                    count++;
                } while (mask <= c);
                break;
            }
        }
    }
}

