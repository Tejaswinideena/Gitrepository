using System;
public class Program14
{
    public static void Main()
    {
        float celsius = 40;
        Console.WriteLine("Temperature in celsius: " + celsius);
        float fahrenheit = ((celsius * 9) / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        Console.ReadKey();
    }
}