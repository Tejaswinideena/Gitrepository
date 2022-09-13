using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Sept12
{
    public class ProgramA
    {
        //Section A Program.cs
        static void Main(string[] args)
        {
            string path = "E:\\Visual Studio Projects\\Sept9\\Library\\bin\\Debug\\Library.dll";

            Assembly asm = Assembly.LoadFrom(path);
            Type[] types = asm.GetTypes();
            Type t = null;
            foreach (var item in types)
            { 

                t = asm.GetType(item.FullName);

                object obj = Activator.CreateInstance(t);

                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod,null, obj, new object[1] {20});

                item.InvokeMember("Sqrt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[1] { 4 });
                break;

            }



            Console.ReadLine();


        }
    }
}