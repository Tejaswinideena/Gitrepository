using System;
public class Program14
{
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            int ch = 0;
            Console.WriteLine("\n");
            while (ch < 4)
            {
                switch (ch)
                {
                    case 0:
                    if (n == 0)
                        Console.WriteLine("Entered Number is Zero,Enter Valid Number!!!");
                    break;
                    case 1:
                        if (n % 2 == 0)
                        {
                            Console.WriteLine("{0} is even", n);
                        }
                        else
                            Console.WriteLine("{0} is odd", n);

                        break;
                    case 2:
                        if (n %10  == 0)
                        {
                            Console.WriteLine("{0} is  a multiple of 10", n);

                        }
                        break;
                    case 3:
                        if (n > 100)
                            Console.WriteLine("Too Large");
                        break;
                    default:
                            Console.WriteLine("Enter Valid Number");
                            break;
                }
                ch++;
            }
            Console.ReadLine();
        }
    
}