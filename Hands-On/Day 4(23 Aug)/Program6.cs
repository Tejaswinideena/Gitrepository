using System;
namespace Program
{
    enum deptnames
    { 
        Purchase =1,
        Sales=2,
        Training=3,
        Accounts=4
    }
    public class Program6
    {

        public static void Main(string[] args)
        {
             
             Console.WriteLine(deptnames.Training);

             int deptno =(int)deptnames.Training;

             Console.WriteLine("\nDept No: "+deptno);

            Console.Read();
        }

    }
}