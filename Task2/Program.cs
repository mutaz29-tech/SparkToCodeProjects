namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Countdown Timer
            //Console.WriteLine("Enter starting number:");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = number; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff !");
            //////////////////////////////////


            ///Task 2 - Sum of Numbers 1 to N
            //Console.WriteLine("Enter positive whole number:");
            //int pnum = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= pnum; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"The sum is :" + sum);
            /////////////////////

            //Task 3 - Multiplication Table
            //Console.Write("Enter a number :");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(num + "*" + i + "=" + (num * i));
            //}
            ////////////////////////////////
            ///Task 4 - Password Retry
            //string password = "Spark2026";
            //string userPassword = "";

            //while (userPassword != password)
            //{
            //    Console.Write("Enter the password :");
            //    userPassword = Console.ReadLine();
            //    if (userPassword != password)
            //    {
            //        Console.WriteLine("Incorrect password, try again");
            //    }
            //}
            //Console.WriteLine("Access Granted");
            //////////////////

            ///Task 5 - Number Guessing Game
            //int secretNumber = 29; // my secret number is 29
            //int gusss;
            //int attempts = 0;

            //do
            //{
            //    Console.Write("Guess the secret number:");
            //    gusss = int.Parse(Console.ReadLine());
            //    attempts++;
            //    if (gusss > secretNumber)
            //    {
            //        Console.WriteLine("Too high");
            //    }
            //    else if (gusss < secretNumber)
            //    {
            //        Console.WriteLine("Too low.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"you gussed the secret number");
            //    }
            //} while (gusss != secretNumber);
            //Console.WriteLine("It took you {attempts} attempts.");
            ////////////////////
            //Task 6 - Safe Division Calculator
            //try
            //{
            //    Console.Write("Enter the first number:");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second number:");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;

            //    Console.WriteLine("resutl is :" + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Division by zero is not allowed.");
            //}

            //catch (FormatException)

            //{
            //    Console.WriteLine(" Invalid input");
            //}
            ///////////////////////////////////////////////

            ///Task 7 - Repeating Menu with Exit Option
            //while (true)
            // {
            //     Console.WriteLine("1. Say Hello");
            //     Console.WriteLine("2. Show Current Time-of-day Greeting");
            //     Console.WriteLine("3. Exit");
            //     Console.Write("Enter your choice: ");

            //     try
            //     {
            //         int choice = int.Parse(Console.ReadLine());

            //         switch (choice)
            //         {
            //             case 1:
            //                 Console.WriteLine("Hello!");
            //                 break;

            //             case 2:
            //                 Console.WriteLine("Good Day! Have a nice day.");
            //                 break;

            //             case 3:
            //                 Console.WriteLine("Exiting program...");

            //                 break;

            //             default:
            //                 Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            //                 break;
            //         }
            //     }
            //     catch (FormatException)
            //     {
            //         Console.WriteLine("Error: Please enter a numeric value.");
            //     }
            // }
            ///////////////////////////////////////////////////////////////////////////////////////
            ///Task 8 - Sum of Even Numbers Only
            //  Console.Write("Enter a positive whole number : ");
            //   int N = int.Parse(Console.ReadLine());
            //   int sum = 0;
            //   for (int i = 1; i <= N; i++)
            //   {
            //// Check if the number is even
            //       if (i % 2 == 0)
            //       {
            //           sum += i;
            //       }
            //   }

            //   Console.WriteLine("The sum of all even numbers from 1 to {N} is: {sum}");

            //////////////////////////////////////////////////////////////////
            ///Task 9 - Validated Positive Number Input            
            //int number = 0;
            //bool validInput = false;
            //// Input loop
            //do
            //{
            //    Console.Write("Enter a positive whole number: ");

            //    try
            //    {
            //        number = int.Parse(Console.ReadLine());

            //        if (number > 0)
            //        {
            //            validInput = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Please enter a number greater than zero.");
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Error: Invalid input. Please enter a whole number.");
            //    }

            //} while (!validInput);

            //// Sum calculation loop
            //int sum = 0;

            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("The sum of all whole numbers from 1 to {number} is: {sum}");

            ///////////////////////////////////////////////////////////////////////////
            ///Task 10 - Simple ATM Simulation
                const int correctPin = 1234;
                double balance = 100.000;
                bool pinAccepted = false;

                // PIN verification (up to 3 attempts)
                for (int attempts = 1; attempts <= 3; attempts++)
                {
                    Console.Write("Enter PIN: ");

                    try
                    {
                        int enteredPin = int.Parse(Console.ReadLine());

                        if (enteredPin == correctPin)
                        {
                            pinAccepted = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect PIN.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid PIN input.");
                    }
                }

                // Block card after 3 failed attempts
                if (!pinAccepted)
                {
                    Console.WriteLine("Card Blocked");
                    return;
                }
                // ATM Menu
                bool running = true;

                while (running)
                {
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                    Console.Write("Choose an option: ");

                    try
                    {
                        int choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1: // Deposit
                                try
                                {
                                    Console.Write("Enter deposit amount: ");
                                    double deposit = double.Parse(Console.ReadLine());

                                    if (deposit < 0)
                                    {
                                        Console.WriteLine("Amount cannot be negative.");
                                    }
                                    else
                                    {
                                        balance += deposit;
                                        Console.WriteLine($"Deposit successful. New Balance: {balance:F3} OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case 2: // Withdraw
                                try
                                {
                                    Console.Write("Enter withdrawal amount: ");
                                    double withdrawal = double.Parse(Console.ReadLine());

                                    if (withdrawal < 0)
                                    {
                                        Console.WriteLine("Amount cannot be negative.");
                                    }
                                    else if (withdrawal > balance)
                                    {
                                        Console.WriteLine("Insufficient balance.");
                                    }
                                    else
                                    {
                                        balance -= withdrawal;
                                        Console.WriteLine($"Withdrawal successful. New Balance: {balance:F3} OMR");
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid amount entered.");
                                }
                                break;

                            case 3: // Check Balance
                                Console.WriteLine($"Current Balance: {balance:F3} OMR");
                                break;

                            case 4: // Exit
                                Console.WriteLine("Thank you for using the ATM.");
                                running = false;
                                break;

                            default:
                                Console.WriteLine("Invalid menu option.");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a valid numeric menu choice.");
                    }
                }
            }
        }


    }
   



   

    
