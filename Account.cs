namespace CreateLoginAccount;

public class Account
{
    // Attribut: Username, Password
    public string Username { get; set; }
    public string Password { get; set; }

    // Här sparar vi alla registrerade konton
    private static List<Account> accounts = new List<Account>();


    // Registrera ett nytt konto
    public bool Register(string username, string password)
    {
        // Kontrollera om användarnamnet redan finns
        bool usernameExists = accounts.Any(account => account.Username == username);

        if (usernameExists)
        {
            return false;
        }

        // Kontrollera lösenordets styrka
        if (!CheckPasswordStrength(password))
        {
            return false;
        }

        // Skapa det nya kontot
        Account newAccount = new Account();

        newAccount.Username = username;
        newAccount.Password = password;

        // Spara kontot i listan
        accounts.Add(newAccount);

        return true;
    }


    // Logga in
    public bool Login(string username, string password)
    {
        // Leta efter ett konto där både username och password stämmer
        bool loginSuccessful = accounts.Any(account =>
            account.Username == username &&
            account.Password == password);

        return loginSuccessful;
    }


    // Kontrollera lösenordets styrka
    public bool CheckPasswordStrength(string password)
    {
        // Exempel på krav:
        // Minst 8 tecken
        // Minst en siffra
        // Minst en stor bokstav

        if (password.Length < 8)
        {
            return false;
        }

        if (!password.Any(char.IsDigit))
        {
            return false;
        }

        if (!password.Any(char.IsUpper))
        {
            return false;
        }

        if (!password.Any(char.IsSymbol) && !password.Any(char.IsPunctuation))
        {
            return false;
        }

        return true;
    }
}