using System.Security.Principal;

namespace OPPTask1solution
{
    //class BankAccoun
    public class BankAccount
    {
        //properties
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        //methods
        //functions 
        public void Desposit(double amount)
        {
            Balance += amount;
            SendEmail(); 
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;

        }
        private void PrintInformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
        }
        //private method 
        private void SendEmail()
        {
            Console.WriteLine("Email notification sent.");
        }
    }
    //class Student
    class Student
    {
        //poroperties (store multi data /function)
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        private string email { get; set; } 
        //methods (functions)
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail()
        {
            Console.WriteLine("Registration email sent");
        }

    }
    //class Product
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        //sell method 
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
                Console.WriteLine($"{quantity} units of {ProductName} sold.");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
            LogTransaction();
        }
        // Restock Method
        public void Restock(int quantity)
        {

            StockQuantity += quantity;
            Console.WriteLine($"{quantity} units of {ProductName} restocked.");
            LogTransaction();
        }
        // Get Inventory Value Method
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        //// Private Method
        private void PrintDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock Quantity: {StockQuantity}");
        }
        // Private Method
        private void LogTransaction()
        {
            Console.WriteLine($"Transaction logged");
        }
    }
    public class Program
    {


        // Bank Accounts
        BankAccount account1 = new BankAccount { AccountNumber = 1163, HolderName = "Karim", Balance = 120 };
        BankAccount account2 = new BankAccount { AccountNumber = 3333, HolderName = "Ali", Balance = 150 };
        // Students
        Student student1 = new Student { Name = "Ahmed", Grade = 10, Addres = "Cairo" };
        Student student2 = new Student { Name = "Sara", Grade = 12, Addres = "Alex" };
        //Product
        Product product1 = new Product { ProductName = "Laptop", Price = 1000, StockQuantity = 10 };
        Product product2 = new Product { ProductName = "Phone", Price = 500, StockQuantity = 20 };
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (exitApp == false)
            {
                //Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                //Console.WriteLine(" 1. View Account Details");
                //Console.WriteLine(" 2. Update Student Address");
                //Console.WriteLine(" 3. Make a Deposit");
                //Console.WriteLine(" 4. Make a Withdrawal");
                ////        Console.WriteLine(" 5. View Product Details");
                ////        Console.WriteLine(" 6. Register a Student");
                ////        Console.WriteLine(" 7. Compare Two Account Balances");
                ////        Console.WriteLine(" 8. Restock Product & Stock Level Check");
                ////        Console.WriteLine(" 9. Transfer Between Accounts");
                ////        Console.WriteLine("10. Update Student Grade (Validated)");
                ////        Console.WriteLine("11. Student Report Card");
                ////        Console.WriteLine("12. Account Health Status");
                ////        Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                ////        Console.WriteLine("14. Scholarship Eligibility Check");
                ////        Console.WriteLine("15. Full Balance Top-Up Flow");
                ////        Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                ////        Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                ////        Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                ////        Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                //Console.WriteLine("20. Exit");
                //Console.Write("Choose an option: ");

                //int choice;
                //try
                //{
                //    choice = int.Parse(Console.ReadLine());
                //}
                //catch (Exception)
                //{
                //    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                //    continue;
                //}

                //switch (choice)
                //{
                //    case 1: ViewAccountDetails(); break;
                //    case 2: UpdateStudentAddress(); break;
                //    case 3: MakeDeposit(); break;
                //    case 4: MakeWithdrawal(); break;
                //    //            case 5: ViewProductDetails(); break;
                //    //            case 6: RegisterStudent(); break;
                //    //            case 7: CompareAccountBalances(); break;
                //    //            case 8: RestockProduct(); break;
                //    //            case 9: TransferBetweenAccounts(); break;
                //    //            case 10: UpdateStudentGrade(); break;
                //    //            case 11: StudentReportCard(); break;
                //    //            case 12: AccountHealthStatus(); break;
                //    //            case 13: BulkSaleWithRevenue(); break;
                //    //            case 14: ScholarshipEligibilityCheck(); break;
                //    //            case 15: FullBalanceTopUpFlow(); break;
                //    //            case 16: QuickAccountOpening(); break;
                //    //            case 17: TotalStudentsCounter(); break;
                //    //            case 18: OverdrawnAccountCheck(); break;
                //    //            case 19: SetStudentSecurityPin(); break;
                //    case 20:
                //        exitApp = true;
                //        Console.WriteLine("Goodbye!");
                //        break;
                //    default:
                //        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                //        break;

                //}

                /// helpers 

                static BankAccount ChooseAccount(BankAccount account1, BankAccount account2)
                {
                    Console.WriteLine("choose account details (1 or 2):");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 2)
                    {
                        return account2;
                    }
                    return account1;
                }
                // stident 
                static Student ChooseStudent(Student student1, Student student2)
                {
                    Console.WriteLine("choose student details (1 or 2):");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 2)
                    {
                        return student2;
                    }
                    return student1;
                }
                //product
                static Product ChooseProduct(Product product1, Product product2)
                {
                    Console.WriteLine("choose product details (1 or 2):");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 2)
                    {
                        return product2;
                    }
                    return product1;
                }

                //Case 1 - View Account Details
                static void ViewAccountDetails(BankAccount account1, BankAccount account2)
                {
                    Console.WriteLine("choose account to view details (1 or 2):");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        account1.CheckBalance();
                    }
                    else if (input == 2)
                    {
                        account2.CheckBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                //////////////////////////////////////////////////////////////
                ///Case 2 - Update Student Address
                static void UpdateStudentAddress(Student student1, Student student2)
                {
                    Student student = ChooseStudent(student1, student2);

                    Console.Write("Enter new address: ");
                    string newAddress = Console.ReadLine();

                    student.Addres = newAddress;

                    Console.WriteLine("Address updated successfully.");
                    Console.WriteLine("New Address: " + student.Addres);
                }
                ////////////////////////////////////////////////////////////////////

                ///Case 3 - Make a Deposit
                static void MakeDeposit(BankAccount account1, BankAccount account2)
                {
                    BankAccount account = ChooseAccount(account1, account2);

                    Console.Write("Enter amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    account.Desposit(amount);

                    Console.WriteLine("Holder Name: " + account.HolderName);
                    Console.WriteLine("Balance: " + account.Balance);
                }
                //////////////////////////////////////////////////////

                ///Case 4 - Make a Withdrawal
                static void MakeWithdrawal(BankAccount account1, BankAccount account2)
                {
                    BankAccount account = ChooseAccount(account1, account2);

                    Console.Write("Enter amount: ");
                    double amount = double.Parse(Console.ReadLine());

                    account.Withdraw(amount);

                    Console.WriteLine("Updated Balance: " + account.Balance);
                }
                //////////////////////////////////////////////////

                ///Case 5 - View Product Details
                static void ViewProductDetails(Product product1,Product product2)
                {
                    Product product = ChooseProduct(product1, product2);

                    double inventoryValue = product.GetInventoryValue();

                    Console.WriteLine("Inventory Value: " + inventoryValue);
                }
                ////////////////////////////////////////////////////////////////////

                ///Case 6 - Register a Student
                static void RegisterStudent(Student student1, Student student2)
                {
                    Student student = ChooseStudent(student1, student2);
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    student.Register(email);
                    Console.WriteLine($"{student.Name} has been registered successfully.");
                }
                ////////////////////////////////////////////////////////////////////////

                ///Case 7 - Compare Two Account Balances
                static void CompareAccountBalances(BankAccount account1, BankAccount account2)
                {
                    if (account1.Balance > account2.Balance)
                    {
                        Console.WriteLine($"{account1.HolderName} has more money.");
                    }
                    else if (account2.Balance > account1.Balance)
                    {
                        Console.WriteLine($"{account2.HolderName} has more money.");
                    }
                    else
                    {
                        Console.WriteLine("Both accounts have the same balance.");
                    }
                }
                //////////////////////////////////////////////////////////////////////////////

                ///Case 8 - Restock Product & Stock Level Check
                static void RestockProduct(Product product1, Product product2)
                {
                    Product product = ChooseProduct(product1, product2);
                    Console.Write("Enter quantity to restock: ");
                    int quantity = int.Parse(Console.ReadLine());
                    product.Restock(quantity);
                    Console.WriteLine("Updated Stock: " + product.StockQuantity);
                    if (product.StockQuantity < 10)
                    {
                        Console.WriteLine("Stock Level: Low");
                    }
                    else if (product.StockQuantity >= 10 && product.StockQuantity <= 49)
                    {
                        Console.WriteLine("Stock Level: Moderate");
                    }
                    else
                    {
                        Console.WriteLine("Stock Level: Well Stocked");
                    }
                }
                //////////////////////////////////////////////////////////////////

                ///Case 9 - Transfer Between Accounts
                static void TransferBetweenAccounts(BankAccount account1, BankAccount account2)
                {
                    Console.WriteLine("Choose source account (1 or 2):");
                    int sourceChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Choose destination account (1 or 2):");
                    int destinationChoice = int.Parse(Console.ReadLine());
                    if (sourceChoice == destinationChoice)
                    {
                        Console.WriteLine("Source and destination accounts must be different.");
                        return;
                    }
                    BankAccount source = (sourceChoice == 1) ? account1 : account2;
                    BankAccount destination = (destinationChoice == 1) ? account1 : account2;
                    Console.Write("Enter transfer amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    if (source.Balance >= amount)
                    {
                        source.Withdraw(amount);
                        destination.Desposit(amount);

                        Console.WriteLine("Transfer completed successfully.");
                        Console.WriteLine($"Source Balance: {source.Balance}");
                        Console.WriteLine($"Destination Balance: {destination.Balance}");
                    }
                    else
                    {
                        Console.WriteLine("Transfer failed: insufficient funds in source account.");
                    }
                }
                ////////////////////////////////////////////////////////////////////

                ///Case 10 - Update Student Grade (Validated)
                static void UpdateStudentGrade(Student student1, Student student2)
                {
                    Student student = ChooseStudent(student1, student2);
                    Console.Write("Enter new grade (0-100): ");
                    if (!int.TryParse(Console.ReadLine(), out int newGrade))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        return;
                    }
                    if (newGrade < 0 || newGrade > 100)
                    {
                        Console.WriteLine("Grade must be between 0 and 100.");
                        return;
                    }
                    student.Grade = newGrade;
                    Console.WriteLine("Grade updated successfully.");
                    Console.WriteLine($"New Grade: {student.Grade}");
                }
            }
        }
    }
}
