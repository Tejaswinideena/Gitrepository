using System;
using System.IO;
using System.Security.Permissions;

public class Program1
{
        public static void Main(string[] args)
        {
            
                    Console.WriteLine("1.create\n2.add\n3.truncate\n");
                    int x = Convert.ToInt32(Console.ReadLine());
                    string path = "E:\\FilesDemo\\";
                    Console.WriteLine("Enter the file name");
                    string fname = Console.ReadLine();
                    fname = string.Concat(path, fname);

                    switch (x)
                    {
                        case 1:

                            FileStream fs = new FileStream(fname, FileMode.Create,FileAccess.Write);
                            StreamWriter sw = new StreamWriter(fs);

                            sw.WriteLine("This is a new file created using Create method.");
                            sw.Close();
                            fs.Close();
                            Console.WriteLine("Created successfully...");
                            break;

                        case 2:

                            FileStream fs1 = new FileStream(fname, FileMode.Append,FileAccess.Write);
                            StreamWriter sw1 = new StreamWriter(fs1);
                            sw1.WriteLine("Add this Contents into existing file.");
                            sw1.Close();
                            fs1.Close();
                            Console.WriteLine("Appended successfully...");
                            break;
                        case 3:

                            FileStream fs2 = new FileStream(fname, FileMode.Truncate, FileAccess.Write);
                            fs2.Close();
                            Console.WriteLine("Truncated successfully...");
                            break;



                    }
     

            
        }
}