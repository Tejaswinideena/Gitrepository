using System;
public class Program15
{
        public static void Main(string[] args)
        {
            int i = 0, j = 25;

            for (i = 0, j = 25; i < 25 && j >= 0; i++, j--)
            {
                if (i > j)
                {
                    Console.WriteLine("\nCrossed Over");
                    break;
                }
                Console.WriteLine("{0} {1}", i, j);
        }
            Console.ReadLine();
        }
    
}
