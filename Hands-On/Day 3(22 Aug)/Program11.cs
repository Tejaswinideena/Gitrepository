using System;
using System.Collections;

public class Program11
{
    public static void Main(string[] args)
    {
        SortedList sl = new SortedList();
        sl.Add(34,"Harish");
        sl.Add(22, "sita");
        sl.Add(16, "Ram");
        Console.WriteLine("The Sorted List : ");
        foreach (DictionaryEntry item in sl)
        {
            Console.WriteLine(item.Key + "  " + item.Value);
        }
    }
}
