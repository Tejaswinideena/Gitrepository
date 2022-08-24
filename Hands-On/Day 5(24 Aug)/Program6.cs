using System;
using System.IO;

namespace ReusableCodeLibrary
{
    public class Program6
    {
        public static void Makefile()
        {
            string path = @"C:\Users\new\Documents\Demo\demo.txt";
            File.Create(path);
        }
    }
}
