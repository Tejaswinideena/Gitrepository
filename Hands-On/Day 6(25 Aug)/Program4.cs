using System;
using System.IO;
public class Program4
{
    public static void Main()
    {   
        DriveInfo[] drivelist = DriveInfo.GetDrives();
        Console.WriteLine("List of All Drives\n");
        foreach (var item in drivelist)
        {
            Console.WriteLine("Drive {0}",item.Name);
        }
        Console.WriteLine("\nC Drive Information");
        DriveInfo info = new DriveInfo("C");
        Console.WriteLine("Name: " +info.Name);
        Console.WriteLine("Totalsize: "+info.TotalSize);
        Console.WriteLine("Type: "+info.DriveType);
        Console.WriteLine("Format: "+info.DriveFormat);

        Console.ReadLine();
    }
}