using System;
public class csharpExercise
{
    static void Main(string[] args)
    {
        double  sub1, sub2, sub3, total;
        double percent;
        string  division;

        
        Console.Write("subject1 : ");
        sub1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("subject2 : ");
        sub2= Convert.ToInt32(Console.ReadLine());
        Console.Write("subject3 : ");
        sub3 = Convert.ToInt32(Console.ReadLine());

        total = sub1 + sub2 + sub3;
        percent = total / 3.0;
        if (percent >= 60)
            division = "First";
        else
            if (percent < 60 && percent >= 48)
            division = "Second";
        else
                if (percent < 48 && percent >= 36)
            division = "Pass";
        else
            division = "Fail";

       
        Console.Write("Total  = {0}\nPercentage = {1}\nDivision = {2}\n", total, percent, division);

        Console.ReadLine();
    }
}