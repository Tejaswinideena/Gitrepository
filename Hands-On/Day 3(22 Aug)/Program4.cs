using System;
using System.Collections;
public class Program4
{
       public static void Main(string[] args)
        {

        ArrayList al = new ArrayList() {5,6,7,3,"welcome"};
        al.Add(78);
        al.Add(85);
        al.Add("Hi");
        al.Remove(85);
        al.RemoveAt(0);

        Console.WriteLine("Elements in Arraylist are: ");
        foreach (var item in al)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nCount is : "+al.Count);
    }
}

