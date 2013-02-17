//Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.
using System;

class KElementsWithSubsetS
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 1; j < Math.Pow(2,n); j++)
        {
            int mask = 1;
            int counter = 0;
            int counterSum = 0;
            int sum = 0;
            do
            {
                if ((mask & j) == mask)
                {
                    sum += arr[counterSum];
                    counter++;
                }
                mask <<= 1;
                counterSum++;
            } while (mask <= j);
            if (counter == k && sum == s)
            {
                Console.WriteLine("yes");
                //for output 
                mask = 1;
                counterSum = 0;
                while (mask < j)
                {
                    if ((mask & j) == mask)
                    {
                        Console.WriteLine("{0}",arr[counterSum]);
                    }
                    mask <<= 1;
                    counterSum++;
                }
                break;
            }
        }
    }
}

