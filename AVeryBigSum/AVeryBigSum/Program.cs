using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static long aVeryBigSum(int n, long[] ar)
    {
        long x = 0;
        foreach (long item in ar)
        {
            x += item;
        }
        return x;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
        long result = aVeryBigSum(n, ar);
        Console.WriteLine(result);
    }
}
