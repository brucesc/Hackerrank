using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            string printString = "";
            int numOfSpaces = n - i;
            int numOfHash = n - numOfSpaces;
            for (int s = 0; s < numOfSpaces; s++)
            {
                printString += " ";
            }
            for (int a = 0; a < numOfHash; a++)
            {
                printString += "#";
            }
                Console.WriteLine(printString);
            
        }

       
        Console.ReadLine();

    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
