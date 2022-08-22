using System;
public class Program6
{
    public static void Main()
    {
        int year;
        Console.Write("Check whether a given year is leap year or not \n");
        Console.Write("Enter a year : ");
        year = Convert.ToInt32(Console.ReadLine());

        if ((year % 400) == 0)
            Console.WriteLine("{0} is a leap year.\n", year);
        else if ((year % 100) == 0)
            Console.WriteLine("{0} is not a leap year.\n", year);
        else if ((year % 4) == 0)
            Console.WriteLine("{0} is a leap year.\n", year);
        else
            Console.WriteLine("{0} is not a leap year.\n", year);
    }
}