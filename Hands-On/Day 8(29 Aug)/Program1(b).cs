using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Program1b
    {
        public static void Main(string[] args)
        {
            //Stack using generic classes
            Userstack<string> u = new Userstack<string>();
            u.Push("Raj");
            u.Push("Lakshman");
            u.Push("Ram");
            u.Push("Sita");
            u.Push("Nina");
            Console.WriteLine("Elements at Stack Before Pop: ");    
            u.printData();
            Console.WriteLine("\nPopped element");
            u.Pop();
            Console.WriteLine("\nElements at Stack After Pop: ");
            u.printData();
            Console.WriteLine("\nPeek element: ");
            string k = u.Peek();
            Console.WriteLine(k);
            Console.ReadLine();


        }

    }
    class Userstack<T>
    {
        internal static int max = 10;
        T[] stack = new T[max];
        int top = -1;
        public void Push(T str)
        {
            if (top >= 10)
            {
                Console.WriteLine("No space on stack");
            }
            else
            {
                stack[++top] = str;
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements on stack");
            }
            else
            {
                T value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            if (top < 0)
            {
                return default(T);
            }
            else
            {
                T value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}