using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string timeConversion(string s)
    {
        DateTime timeValue = Convert.ToDateTime(s);
        string military = timeValue.ToString("HH:mm:ss");
        return military;
    }

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
        Console.ReadKey();

    }
}
