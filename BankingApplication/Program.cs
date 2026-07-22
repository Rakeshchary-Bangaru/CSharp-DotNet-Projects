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
                    case 1:
                        CustomersMenu();// Customers
                        break;
                    case 2:
                        AccountsMenu();// Accounts
                        break;
                    case 3:
                        System.Console.WriteLine("Transaction");// Transactions
                        break;
                    case 4:
                        System.Console.WriteLine("Transfer Statements");// Transfer Statements
                        break;
                    case 5:
                        System.Console.WriteLine("Account Statement");// Account Statement
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

    static void CustomersMenu()
    {
        // variable to store customers menu choice
        int customersmenuchoice = -1;

        // do while loop starts
        do
        {
            // print customers menu
            System.Console.WriteLine("\n ::: Customers Menu :::");
            System.Console.WriteLine("1. Add Customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. View Customer");
            System.Console.WriteLine("0. Back to Main Menu");

            // accept customers menu choice 
            System.Console.Write("Enter your choice: ");
            customersmenuchoice = int.Parse(System.Console.ReadLine() ?? "");

        } while (customersmenuchoice != 0);


    }
    
    static void AccountsMenu()
    {
        // variable to store accounts menu choice
        int accountsmenuchoice = -1;

        // do while loop starts
        do
        {
            // print accounts menu
            System.Console.WriteLine("\n ::: Accounts Menu :::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Back to Main Menu");

            // accept accounts menu choice 
            System.Console.Write("Enter your choice: ");
            accountsmenuchoice = int.Parse(System.Console.ReadLine() ?? "");

        } while (accountsmenuchoice != 0);


    }
}