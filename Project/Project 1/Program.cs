using System;
using System.IO;
namespace MyProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "E:\\Project\\Project 1\\Student Details.txt";
            string studentfile=File.ReadAllText(path);
            Console.WriteLine(studentfile);
        }
    }
}
