using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program1a
    {

        public static void Main(string[] args)
        {
            //Linked List using generic classes
            GenericsLinkedList<string> str = new GenericsLinkedList<string>(); 
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "C Sharp";
            string s4 = "Training";
            str.AddHead(s1);
            str.AddHead(s2);
            str.AddHead(s3);
            str.AddHead(s4);
            foreach (string Str in str)
            {
                Console.WriteLine(Str);
            }
            Console.ReadKey();
        }
    }

    class GenericsLinkedList<T>
    {
        class LinkedlistNode
        {
            private LinkedlistNode next;
            private T item;

            public LinkedlistNode(T t)
            {
                next = null;
                item = t;

            }
            public LinkedlistNode Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }
            public T Item
            {
                get
                {
                    return item;
                }
                set
                {
                    item = value;
                }
            }
        }
        private LinkedlistNode head;
        public GenericsLinkedList()
        {
            head = null;
        }
        public void AddHead(T t)
        {
            LinkedlistNode node = new LinkedlistNode(t);
            node.Next = head;
            head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            LinkedlistNode current = head;
            while (current != null)
            {
                yield return current.Item;
                current = current.Next;
            }

        }
    }
}