using System;
class Program4
{
    static void Main(string[] args)
    {
        string s1;
        string s2;
        Console.Write("Enter a string: ");
        s1 = Console.ReadLine();
        Console.Write("Enter another string: ");
        s2 = Console.ReadLine();
        if (s1 == s2)
            Console.WriteLine("\"{0}\" and \"{1}\" are equal", s1, s2);
        else
            Console.WriteLine("\"{0}\" and \"{1}\" are not equal", s1, s2);
       
        Console.ReadLine();
    }
}