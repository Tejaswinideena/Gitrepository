using System;
using System.Collections.Generic;
public class Program10
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(34, "Harish");
        dict.Add(22, "Sita");
        dict.Add(16, "Ram");
        Console.WriteLine("Values in Dictionary are: \n");
        foreach (KeyValuePair<int, string> item in dict)
        {
            Console.WriteLine(item.Key + "  " + item.Value);

        }
        Console.ReadKey();
    }
}
