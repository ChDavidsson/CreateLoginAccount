namespace CreateLoginAccount;

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();

        bool running = true;

        while (running)
        {
            MenuHelper.ShowMenu();

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Console.Write("Användarnamn: ");
                    string username = Console.ReadLine()!;

                    Console.Write("Lösenord: ");
                    string password = Console.ReadLine()!;

                    bool registered = account.Register(username, password);

                    if (registered)
                    {
                        Console.WriteLine("Registreringen lyckades!");
                    }
                    else
                    {
                        Console.WriteLine("Registreringen misslyckades.");
                    }

                    break;


                case "2":
                    Console.Write("Användarnamn: ");
                    string loginUsername = Console.ReadLine()!;

                    Console.Write("Lösenord: ");
                    string loginPassword = Console.ReadLine();

                    bool loggedIn = account.Login(loginUsername, loginPassword);

                    if (loggedIn)
                    {
                        Console.WriteLine("Inloggning lyckades!");
                    }
                    else
                    {
                        Console.WriteLine("Fel användarnamn eller lösenord.");
                    }

                    break;


                case "3":
                    Console.WriteLine("Programmet avslutas.");
                    running = false;
                    break;


                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }

            Console.WriteLine();
        }
    }
}