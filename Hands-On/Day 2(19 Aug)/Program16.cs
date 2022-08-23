using System;
public class Program16
{
        public static void Main(string[] args)
        {
            int i;
            string str = " ";
            int sum = 100;
            for (i = 0; i < 4; i++)
            {
                str = Console.ReadLine();
                if (str.Equals("hit"))
                {
                    sum += 10;
                }
                else if (str.Equals("miss"))
                {
                    sum -= 20;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    
}