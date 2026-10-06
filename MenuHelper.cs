namespace CreateLoginAccount;

static class MenuHelper
{
    public static void ShowMenu()
    {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("*********************************");
    Console.WriteLine("Welcome to the Account Management System");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");
    Console.WriteLine("Välj: ");
    Console.WriteLine("*********************************");
    }
}
