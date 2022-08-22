using System;
public class Program5
{      
        public static void Main(string[] args)
        {
            int[][] classroom = new int[5][];


            classroom[0] = new int[] { 1, 2, 3, 4 };
            classroom[1] = new int[] { 11, 34, 67 };
            classroom[2] = new int[] { 89, 23 };
            classroom[3] = new int[] { 0, 45, 78, 53, 99 };
            classroom[4] = new int[] { 25, 48, 93, 39 };

            for (int n = 0; n <classroom.Length; n++)
            {

                Console.Write("Students in Classroom[{0}]: \n", n);

                for (int k = 0; k < classroom[n].Length; k++)
                {
                  Console.Write("{0} ", classroom[n][k]);
                }
                Console.WriteLine("\n");
            }
        }
}

