using System;
public class Program7
{
    public static void Main()
    {
        int num;
        //1
        Console.WriteLine("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.Write(" ");
        Console.Write(num);
        Console.WriteLine();
        //2
        Console.Write(num);
        Console.Write(num);
        Console.Write(num);
        Console.WriteLine(num);
        Console.WriteLine();
        //3
        Console.WriteLine("{0} {0} {0} {0}", num);
        //4
        Console.WriteLine("{0}{0}{0}{0}", num);
    }
}