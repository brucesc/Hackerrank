using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int birthdayCakeCandles(int n, int[] ar)
    {
        int max = ar[0];
        for (int i = 1; i < n; i++)
        {
            if (ar[i] > max)
            {
                max = ar[i];
            }
        }

        int counter = 0;

        foreach (int candle in ar)
        {
            if (candle == max)
            {
                counter += 1;
            }
        }
        return counter;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
