using System;
using System.IO;
using System.Linq;
public class Program3
{
        public static void Main(string[] args)
        {
            string path = "E:\\FilesDemo\\";
            Directory.CreateDirectory(path + "Results");
            Console.WriteLine("Directory created");

            string path1 = "E:\\FilesDemo\\Results\\";
            Directory.CreateDirectory(path1 + "Results17-18");
            Directory.CreateDirectory(path1 + "Results18-19");
            Directory.CreateDirectory(path1 + "Results20-21");
            Console.WriteLine("Sub directories created");

            string path2 = "E:\\FilesDemo\\Results\\Results17-18\\";
            string path3 = "E:\\FilesDemo\\Results\\Results18-19\\";
            string path4 = "E:\\FilesDemo\\Results\\Results20-21\\";

            File.Create(path2 + "demo1.txt");
            File.Create(path2 + "demo2.txt");
            File.Create(path3 + "demo1.txt");
            File.Create(path3 + "demo2.txt");
            File.Create(path4 + "demo1.txt");
            File.Create(path4 + "demo2.txt");
            Console.WriteLine("2 Files got created in all subdirectories...");

            Directory.CreateDirectory(path2 + "Jan");
            Directory.CreateDirectory(path2 + "Feb");
            Directory.CreateDirectory(path2 + "Mar");
            Directory.CreateDirectory(path2 + "Apr");
            Directory.CreateDirectory(path2 + "May");
            Directory.CreateDirectory(path2 + "Jun");
            Directory.CreateDirectory(path2 + "Jul");
            Directory.CreateDirectory(path2 + "Aug");
            Directory.CreateDirectory(path2 + "Sep");
            Directory.CreateDirectory(path2 + "Oct");
            Directory.CreateDirectory(path2 + "Nov");
            Directory.CreateDirectory(path2 + "Dec");

            Directory.CreateDirectory(path3 + "Jan");
            Directory.CreateDirectory(path3 + "Feb");
            Directory.CreateDirectory(path3 + "Mar");
            Directory.CreateDirectory(path3 + "Apr");
            Directory.CreateDirectory(path3 + "May");
            Directory.CreateDirectory(path3 + "Jun");
            Directory.CreateDirectory(path3 + "Jul");
            Directory.CreateDirectory(path3 + "Aug");
            Directory.CreateDirectory(path3 + "Sep");
            Directory.CreateDirectory(path3 + "Oct");
            Directory.CreateDirectory(path3 + "Nov");
            Directory.CreateDirectory(path3 + "Dec");

           Directory.CreateDirectory(path4 + "Jan");
           Directory.CreateDirectory(path4 + "Feb");
           Directory.CreateDirectory(path4 + "Mar");
           Directory.CreateDirectory(path4 + "Apr");
           Directory.CreateDirectory(path4 + "May");
           Directory.CreateDirectory(path4 + "Jun");
           Directory.CreateDirectory(path4 + "Jul");
           Directory.CreateDirectory(path4 + "Aug");
           Directory.CreateDirectory(path4 + "Sep");
           Directory.CreateDirectory(path4 + "Oct");
           Directory.CreateDirectory(path4 + "Nov");
           Directory.CreateDirectory(path4 + "Dec");
           Console.WriteLine("MonthWise Folder created in all subdirectories");
        
        var dir2 = from Dir in Directory.EnumerateDirectories(path1) select Dir;
        Console.WriteLine("List of Subdirectories in Results: ");
        foreach (var dir in dir2)
        {
            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
        }

        
        var dir3 = from MyDir in Directory.EnumerateDirectories(path2) select MyDir;
        Console.WriteLine("\nList of Subdirectories in Results17-18: ");
        foreach (var dir in dir3)
        {
            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
        }

       
        var dir4 = from MyDir in Directory.EnumerateDirectories(path3) select MyDir;
        Console.WriteLine("\nList of Subdirectories in Results18-19");
        foreach (var dir in dir4)
        {
            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
        }

        var dir5 = from MyDir in Directory.EnumerateDirectories(path4) select MyDir;
        Console.WriteLine("\nList of Subdirectories in Results20-21");
        foreach (var dir in dir5)
        {
            Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
        }
        Console.ReadLine();
        }
    
}