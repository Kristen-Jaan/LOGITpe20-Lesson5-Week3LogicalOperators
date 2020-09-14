using System;

namespace Week3LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning.");
            Console.WriteLine("What Is Your Login And Password?");
            string Login;
            string Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password:");
            Password = Console.ReadLine();


            if ((Login == "admin") && (Password == "pass1234"))
                Console.WriteLine("Welcome!");
            else if ((Login == "admin") && (Password != "pass1234"))
                Console.WriteLine("The Password Is Incorrect.");
            else if ((Login != "admin") && (Password == "pass1234"))
                Console.WriteLine("The Login Is Incorrect.");
            else
                Console.WriteLine("Please Stop Trying To Hack This Account Or I Will Call The FBI.");
        }
    }
}
