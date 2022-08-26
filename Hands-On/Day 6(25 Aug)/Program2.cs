using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

public class Program2
{
    public static void Main(string[] args)
    {
        string path = "E:\\FilesDemo\\";
        string path1 = "E:\\FilesDemo\\Demo\\";
        Console.WriteLine("Enter the file name");
        string fname = Console.ReadLine();
        fname = string.Concat(path, fname);

        File.Create(fname);
        Console.WriteLine("Created Successfully");

        string str = "This is new file";
        File.WriteAllText(fname, str);
        Console.WriteLine("Added Successfully");

        Console.WriteLine("Enter copy file Name: ");
        string copy = Console.ReadLine();
        File.Copy(fname, path + copy);
        Console.WriteLine("Copied to same folder");

        File.Copy(fname, path1 + copy);
        Console.WriteLine("Copied to different folder");

        File.Move(fname,path1 + "movehello.txt");
        Console.WriteLine("Moved to different folder");

        File.Delete(fname);
        Console.WriteLine("Deleted successfully");

        FileInfo fileInfo = new FileInfo(fname);
        Console.WriteLine("Extension: "+fileInfo.Extension);
        Console.WriteLine("DirectoryName: "+fileInfo.DirectoryName);
        Console.WriteLine("TimeOfCreation: "+fileInfo.CreationTime);

        Console.ReadLine();
    }
}

