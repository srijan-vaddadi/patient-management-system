using System;

public class UserInteraction
{
    public static void Main()
    {
        Console.Write("Would you like to login or terminate the program: ");
        string action = Console.ReadLine();
        
        Login(action);
    }
    public static void Login(string action)
    {
        if (action == "login")
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            PasswordReceiver(username);
        }
    }

    public static void PasswordReceiver(string username)
    {
        Console.Write("Do you know your password: ");
        string passwordRemebered = Console.ReadLine();

        if (passwordRemebered == "yes")
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
        }
        else
        {
            ForgotPassword(username);
        }
    }
    public static void ForgotPassword(string username) { }

}