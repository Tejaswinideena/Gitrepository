using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

public class Program2
{
    public static void Main(string[] args)
    {
        //string path = "E:\\FilesDemo\\";
        //Console.WriteLine("Enter the file name");
        //string fname = Console.ReadLine();
        //fname = string.Concat(path, fname);
        //File.Create(fname);
        //Console.WriteLine("Created Successfully");
        //string str = "This is new file";
        //File.WriteAllText(fname, str);
        //Console.WriteLine("Added Successfully");
        //File.Copy(fname,"copyhello.txt");
        //File.Move(fname,"movehello.txt");
        //File.Delete(fname);
        //FileInfo fileInfo = new FileInfo(fname);
        //Console.WriteLine("Extension: "+fileInfo.Extension);
        //Console.WriteLine("DirectoryName: "+fileInfo.DirectoryName);
        //Console.WriteLine("TimeOfCreation: "+fileInfo.CreationTime);
        //Directory.CreateDirectory("Results");
        string Results= "E:\\FilesDemo\\Results";
        //string Results17_18= "E:\\FilesDemo\\Results\\";
        //if (!Directory.Exists(Results))
        //{
        //    Directory.CreateDirectory(Results);
        //}
        
        Directory.CreateDirectory(Path.Combine(Results,"Results17-18!"));
        Console.ReadLine();

    }
}

