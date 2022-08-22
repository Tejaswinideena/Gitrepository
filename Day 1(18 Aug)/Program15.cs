using System;

class Program15
{
    static void Main(string[] args)
    {

        double usd = 0;
        double inr = 0;
       

        Console.Write("Enter amount in USD: ");
        usd = double.Parse(Console.ReadLine());

       

        inr = usd * 79.62;
        Console.WriteLine("USD " + usd + "-> INR " + inr);
    }
}