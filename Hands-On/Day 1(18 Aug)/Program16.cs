using System;
public class Program16
{
  public static void Main(string[] args)
  {
            String Firstname, Lastname;
            Console.WriteLine("Enter First Name which is User ID:");
            Firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name which is Password:");
            Lastname = Console.ReadLine();
            if (!string.IsNullOrEmpty(Firstname) && !string.IsNullOrEmpty(Lastname))
            {
                Console.WriteLine("Successfully logged in");
                Console.WriteLine("Welcome to my app");
            }
            else
            {
                Console.WriteLine("check username");
            }

            Console.ReadLine();
  }
}

