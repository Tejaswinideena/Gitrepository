using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program7
{
    public static void Main(string[] args)
    {
        Queue q = new Queue();

        q.Enqueue(1);
        q.Enqueue(2); 
        q.Enqueue(3);

        Console.Write("Original Queue: ");
        foreach (int i in q)
        {
            Console.Write(i + " ");
        }
    
        q.Dequeue();
   
        Console.WriteLine();

        Console.Write("After Dequeue: ");

        foreach (int i in q)
        {

            Console.Write(i + " ");
        }
   
        Console.WriteLine();
        Console.WriteLine("Peek element is: {0}", q.Peek());
    }
}