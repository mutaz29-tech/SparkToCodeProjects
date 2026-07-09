namespace MiniProjectsolution
{
    
        
       
        internal class Program
        {
            static List<string> customerNames = new List<string>();
            static List<string> accountNumbers = new List<string>();
            static List<double> balances = new List<double>();

            static void Main(string[] args)
            {
                bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close Account");
                Console.WriteLine("8. Exit");

                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;

                    case 2:
                        DepositMoney();
                        break;

                    case 3:
                        WithdrawMoney();
                        break;

                    case 4:
                        ShowBalance();
                        break;

                    case 5:
                        TransferAmount();
                        break;

                    case 6:
                        ListAllAccounts();
                        break;

                    case 7:
                        CloseAccount();
                        break;

                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;

                }
            }
        }


  
        ///Service 1 - Add New Account
        
        static void AddAccount()
        {
            Console.WriteLine("Add new account:");
            Console.WriteLine("Enter cusomer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter cusomer account number:");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber)) // to check it their is dublicate account number
            {
                Console.WriteLine("Account already exists.");
                return;
            }


            double deposit;

            try
            {
                Console.Write("Enter initial deposit: ");
                deposit = double.Parse(Console.ReadLine());


                // Check if deposit is negative

                if (deposit < 0)
                {
                    Console.WriteLine("Deposit cant be negative.");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid amount.");
                return;
            }


            // Add data to all lists

            customerNames.Add(name);
            accountNumbers.Add(accountNumber);
            balances.Add(deposit);


            Console.WriteLine("Account created successfully.");
        }

        //Service 2 - Deposit Money
        static void DepositMoney()
        {

            Console.WriteLine("...........DepositMoney........");

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();


            int index = accountNumber.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found");
                return;

            }
            double amount;

            try
            {
                Console.Write("Enter deposit amount: ");
                amount = double.Parse(Console.ReadLine());

                // to make sure that amount is positive

                if (amount <= 0)
                {
                    Console.WriteLine("amount has to be Posititve");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }
            // for updating the balance

            balances[index] += amount;


            Console.WriteLine("Deposit successful.");
            Console.WriteLine("Balance: " + balances[index]);
        }
        
        //Service 3 - Withdraw Money
        static void WithdrawMoney()
        {
            Console.Write("...WithdrawMoney...: ");
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int indx = accountNumbers.IndexOf(accountNumber);
            if (indx == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            double amount;

            try
            {
                Console.Write("Enter withdrawal amount: ");
                amount = double.Parse(Console.ReadLine());

                // check for withdrawal

                if (amount <= 0)
                {
                    Console.WriteLine("Amount must be positive.");
                    return;
                }
                if (amount > balances[indx])
                {
                    Console.WriteLine("Balance too low");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }
            balances[indx] -= amount;


            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Balance: " + balances[indx]);
        }
        //Service 4 - Show Balance
        static void ShowBalance()
        {
            Console.Write("...ShowBalance...: ");
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int indx = accountNumbers.IndexOf(accountNumber);
            if (indx == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            Console.WriteLine("\nCustomer: " + customerNames[indx]);
            Console.WriteLine("Account Number: " + accountNumbers[indx]);
            Console.WriteLine("Balance: " + balances[indx]);
        }
       
        /// Service 5 - Transfer Amount
        static void TransferAmount()
        {
            Console.WriteLine("///Transfer Amount..."); 
            Console.WriteLine("send account number");
            string send = Console.ReadLine();
            Console.WriteLine("Receiv account number");
            string Receive = Console.ReadLine();
            int sendIndex = accountNumbers.IndexOf(send);
            int ReceiveIndex = accountNumbers.IndexOf(Receive);
            if (sendIndex == -1 || ReceiveIndex == -1)
            {
                Console.WriteLine("Account dose not exist");
                return;
            }
            if (sendIndex == ReceiveIndex)
            {
                Console.WriteLine("cant transfear to same account");
                return;
            }
            double amount;

            try
            {
                Console.WriteLine("Enter transfer amount: ");
                amount = double.Parse(Console.ReadLine());

                if (amount <= 0)
                {
                    Console.WriteLine("Amount must be positive.");
                    return;
                }
                if (amount > balances[sendIndex])
                {
                    Console.WriteLine("balnace is not enough");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("invalid amount");
                return;
            }

            balances[sendIndex] -= amount;
            balances[ReceiveIndex] += amount;
            Console.WriteLine("Transfer successful.");
        }
        // CUSTOM SERVICE 1: LIST ALL ACCOUNTS

        static void ListAllAccounts()
        {
            Console.WriteLine("...ListAllAccounts...");

            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("their is no accounts avalibe");
                return;
            }
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                Console.WriteLine("name:" + customerNames[i]);
                Console.WriteLine("account:" + accountNumbers[i]);
                Console.WriteLine("Balance:" + balances[i]);
            }
        }
        
        // custometr service 2:close account
        static void CloseAccount()
        {
            Console.Write("Enter Account Number to Close: ");
            string accountNo = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNo);
            if (index == -1)
            {
                Console.WriteLine("Account not found.");
                return;
            }
            // Remove data from ALL three lists
            customerNames.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            balances.RemoveAt(index);
            Console.WriteLine("Account Closed Successfully!");
        }



    }
}
