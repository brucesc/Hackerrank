using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int diagonalDifference(int[][] a)
    {
        int primary = 0;

        for (int r = 0; r < a.Length; r++)
        {
            primary += a[r][r];
        }

        int secondary = 0;

        int x = a.Length - 1;

        for (int c = a.Length - 1; c >= 0; c--)
        {
            secondary += a[x - c][c];
        }

        int absDiff = Math.Abs(primary - secondary);

        return absDiff;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for (int a_i = 0; a_i < n; a_i++)
        {
            string[] a_temp = Console.ReadLine().Split(' ');
            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
        }
        int result = diagonalDifference(a);
        Console.WriteLine(result);
    }
}
