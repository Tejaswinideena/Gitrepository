using System;
using System.Collections.Generic;
public class Program6
{
        public static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(90);
            st.Push(20);
            st.Push(30);
            st.Push(50);
            st.Push(35);
            
            Console.WriteLine("Stack Elements Before Pop");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            st.Pop();
            Console.WriteLine("\nStack Elements After Pop");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("\ncount of elements in stack: " + st.Count);
            Console.WriteLine("\ntop element: "+st.Peek());
             
            Console.ReadLine();
        }
}

