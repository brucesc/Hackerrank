using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void miniMaxSum(long[] arr)
    {
        Array.Sort(arr);
        long min = arr[0] + arr[1] + arr[2] + arr[3];
        long max = arr[1] + arr[2] + arr[3] + arr[4];

        Console.WriteLine($"{min} {max}");
    }

    static void Main(String[] args)
    {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
        miniMaxSum(arr);
    }
}
