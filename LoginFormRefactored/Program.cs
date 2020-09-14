using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning.");
            Console.WriteLine("What Is Your Login And Password?");
            string Login, Password;
            Console.WriteLine("Login: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
                Password = Console.ReadLine();
            if (Login == "admin" && Password == "pass1234")
                Console.WriteLine("Welcome, admin!");
            else
                Console.WriteLine("Please Stop Trying To Hack This Account Or I Will Call The FBI.");
        }
    }
}
