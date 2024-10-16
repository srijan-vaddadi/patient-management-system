public class UserInteraction
{
    public static void Main()
    {
        Console.Write("Would you like to login or terminate the program: ");
        string action = Console.ReadLine();

        if (action == "login")
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Do you know your password: ");
            string passwordRemebered = Console.ReadLine();

            if (passwordRemebered == "yes")
            {
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
            }
            else
            {
                ForgotPassword();
            }
        }
    }

    public static void ForgotPassword() { }
}