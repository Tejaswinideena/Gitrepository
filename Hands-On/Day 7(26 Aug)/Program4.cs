using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program4
{
        public static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("jack");
            list.AddLast("veena");
            list.AddAfter(list.First, "jill");
            list.AddBefore(list.Last, "jim");
            list.AddBefore(list.Last.Previous, "pari");
            list.AddAfter(list.First.Next, "hari");
            LinkedListNode<string> foundnode = list.Find("jim");
            foundnode.Value = "don";

            foreach (var item in list)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    
}