class BankingApplication
{
    static void Main()
    {
        System.Console.WriteLine("Welcome to the Micro Bank");
        System.Console.WriteLine("***** Login Page *****");

        

        System.Console.Write("Username: ");
        string username = System.Console.ReadLine() ?? "";
        string password = "";

        if (!string.IsNullOrWhiteSpace(username))
        {
            System.Console.Write("Password: ");
             password = System.Console.ReadLine() ?? "";
        }

        if (username == "admin" && password == "123")
        {
            System.Console.WriteLine("Welcome Admin...");
            System.Console.WriteLine("***** Main Menu *****");
        }
        else
        {
            System.Console.WriteLine("Invalid username or password.");
        }
    }
}