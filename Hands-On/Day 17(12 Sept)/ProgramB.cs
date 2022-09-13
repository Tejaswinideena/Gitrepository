using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sept12
{
    public  class ProgramB
    {
        static void Main(string[] args)
        {
            //Section B Program.cs
            ProgramB.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Class: " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t); 

            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.SongName);

                }
            }
            
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute a = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(a.SongName);
                        System.Console.WriteLine(a.Language);
                        System.Console.WriteLine(a.Lyrics);
                    }
                }

            }
        }

    
    }
}