using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void plusMinus(int[] arr)
    {
        int pos = 0;
        int neg = 0;
        int zer = 0;

        foreach (int nbr in arr)
        {
            

            if (nbr > 0)
            {
                pos += 1;
            }
            else if (nbr < 0)
            {
                neg += 1;
            }
            else if (nbr == 0)
            {
                zer += 1;
            }
           
        }
       decimal arLen = arr.Length;

        decimal posDec = (decimal) pos / arLen;
        decimal negDec = (decimal) neg / arLen;
        decimal zerDec = (decimal) zer / arLen;

        Console.WriteLine(posDec);
        Console.WriteLine(negDec);
        Console.WriteLine(zerDec);



        Console.ReadKey();

    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        plusMinus(arr);
    }
}