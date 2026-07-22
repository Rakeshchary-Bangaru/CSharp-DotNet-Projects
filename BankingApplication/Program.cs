using System.Diagnostics;

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

            int mainmenuchoice = -1;


            do
            {
                // Show Main Menu
                System.Console.WriteLine("\n ::: Main Menu :::");
                System.Console.WriteLine("1. Customers");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Transaction");
                System.Console.WriteLine("4. Transfer Statements");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //Accept menu choice from user 
                System.Console.WriteLine("Enter your choice: ");
                mainmenuchoice = int.Parse(System.Console.ReadLine() ?? "0");

                switch (mainmenuchoice)
                {
                    case 1 : System.Console.WriteLine("Customers");// Customers
                        break;
                    case 2 : System.Console.WriteLine("Accounts");// Accounts
                        break;
                    case 3 : System.Console.WriteLine("Transaction");// Transactions
                        break;
                    case 4 : System.Console.WriteLine("Transfer Statements");// Transfer Statements
                        break;
                    case 5 : System.Console.WriteLine("Account Statement");// Account Statement
                        break;   
                

                }
            } while (mainmenuchoice != 0);

            
        }
        else
        {
            System.Console.WriteLine("Invalid username or password.");
        }

        System.Console.WriteLine("Thank you visit again...");
    }
}