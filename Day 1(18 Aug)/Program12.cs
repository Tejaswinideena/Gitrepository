using System;
public class Program12
 {
    public static void Main(string[] args)
    {
        string s1 = "Hello";

        string s2 = "";

        string s3 = null;

        bool b1 = string.IsNullOrEmpty(s1);

        bool b2 = string.IsNullOrEmpty(s2);

        bool b3 = string.IsNullOrEmpty(s3);

        Console.WriteLine(b1);

        Console.WriteLine(b2); 
        Console.WriteLine(b3);
    }
 }

