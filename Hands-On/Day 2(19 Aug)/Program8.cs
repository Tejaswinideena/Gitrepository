using System;
public class Program8
{
    public static void Main(string[] args)
    {
        int x, y;
        for (x = 1; x <= 5; x++)

        {
            for (y = 1; y <= x; y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
  
    }
}

