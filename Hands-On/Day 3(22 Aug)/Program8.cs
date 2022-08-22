using System;
using System.Collections;
public class Program8
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        
        ht.Add(1,"Arun");

        ht.Add(2,"Ramesh");

        ht.Add(3,"Parin");

        Console.WriteLine("Elements in Hashtable: \n");

        foreach (DictionaryEntry ele in ht)

        {
            Console.WriteLine("{0}  {1}", ele.Key, ele.Value);
        }

        Console.WriteLine("\n");
        ht.Remove(2);

        Console.WriteLine("Elements in Hashtable after Removal: \n");
        
        foreach (DictionaryEntry ele in ht)

        {
            Console.WriteLine("{0}  {1}", ele.Key, ele.Value);
        }

    }
}
