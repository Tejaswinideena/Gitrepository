using System;

public class Program14
{

    public static int count(int[] S, int m, int n)
    {
        if (n == 0)
            return 1;

        if (n < 0)
            return 0;

        if (m <= 0)
            return 0;
            return count(S, m - 1, n) + count(S, m, n - S[m - 1]);
    }


    public static void Main()
    {

        int[] arr = { 1, 2, 3 };
        int m = arr.Length;
        Console.Write(count(arr, m, 4));


    }
}
