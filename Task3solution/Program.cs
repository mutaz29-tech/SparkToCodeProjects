namespace Task3solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Absolute Difference
            //Console.WriteLine("enter first number");
            //int num1= int.Parse(Console.ReadLine());
            //Console.WriteLine("enter second number");
            //int num2 = int.Parse(Console.ReadLine());
            //double sub =Math.Abs(num1 - num2);
            //Console.WriteLine(sub);
            ////////////////////////////////////////

            ///Task 2 - Power & Root Explore
            //Console.WriteLine("enter number");
            //int number = int.Parse(Console.ReadLine());
            //double pow = Math.Pow(number,2);
            //double sqrt = Math.Sqrt(number);
            //Console.WriteLine("power is " + pow);
            //Console.WriteLine("square root is " + sqrt);
            ////////////////////////////////////////////////

            ///Task 3 - Name Formatter
            //Console.WriteLine("enter your full name");
            //string name = Console.ReadLine();
            //int length= name.Length;
            //String lower=name.ToLower();
            //String upper = name.ToUpper();
            //Console.WriteLine("length is " + length);
            //Console.WriteLine("lower case is " + lower);
            //Console.WriteLine("upper case is " + upper);
            /////////////////////////////////////////////////////

            //Task 4 - Subscription End Date
            //Console.Write("Enter the number of days for the free trial: ");
            //int trialDays = int.Parse(Console.ReadLine());
            //DateTime startDate = DateTime.Today;
            //DateTime endDate = startDate.AddDays(trialDays);
            //Console.WriteLine("Trial End Date: " + endDate);
            ///////////////////////////////////////////////////////

            //Task 5 - Grade Rounding System
            //Console.Write("Enter your exam score: ");
            //double rawScore = double.Parse(Console.ReadLine());
            //double roundedScore = Math.Round(rawScore, 0);
            //if (roundedScore >= 60)
            //{
            //    Console.WriteLine($"Rounded Score: " + roundedScore);
            //    Console.WriteLine("Result: Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Rounded Score: " + roundedScore);
            //    Console.WriteLine("Result: Fail");
            //}
            ///////////////////////////////////////

            ///Task 6 - Password Strength Checker
            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();

            //if (password.Length >= 8 && !password.ToLower().Contains("password")) //at least 8 characters and does not contain the word "password"
            //{
            //    Console.WriteLine("Your password is strong.");
            //}
            //else
            //{
            //    Console.WriteLine("Your password is weak.");
            //}
            //if (password.Length < 8)
            //{
            //    Console.WriteLine("Password should be at least 8 characters long.");
            //}
            //if (password.ToLower().Contains("password"))
            //{
            //    Console.WriteLine("Password should not contain the word 'password'.");
            //}
            ////////////////////////////////////////////////////////////

            ///Task 7 - Clean Name Comparator
            //Console.Write("Enter the name (first time): ");
            //string name1 = Console.ReadLine().Trim().ToUpper();
            //Console.Write("Enter the name (second time): ");
            //string name2 = Console.ReadLine().Trim().ToUpper();
            //if (name1 == name2)
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}
            ///////////////////////////////////////////////////////////////

            ///Task 8 - Membership Expiry Checker
            //try
            //{
            //    Console.Write("Enter membership start date: ");
            //    string inputDate = Console.ReadLine();
            //    DateTime startDate = DateTime.Parse(inputDate);
            //    Console.Write("Enter number of valid membership days: ");
            //    int membershipDays = Convert.ToInt32(Console.ReadLine());
            //    DateTime expiryDate = startDate.AddDays(membershipDays);
            //    if (expiryDate >= DateTime.Today)
            //    {
            //        Console.WriteLine("Status: Active");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Status: Expired");
            //    }

            //    Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            //}

            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid date and number of days.");
            //}
            ///////////////////////////////////////////////////////////////////////////////

            ///Task 9 - Round Up / Round Down Explorer
            //Console.WriteLine("Enter a decimal number:");
            //double decimalNumber = Convert.ToDouble(Console.ReadLine());
            //double neares = Math.Round(decimalNumber);
            //double roundUp = Math.Ceiling(decimalNumber); // round up to the nearest whole number
            //double roundDown = Math.Floor(decimalNumber); // round down to the nearest whole number
            //Console.WriteLine("Nearest whole number: " + neares);
            //Console.WriteLine("Rounded up: " + roundUp);
            //Console.WriteLine("Rounded down: " + roundDown);
            //////////////////////////////////////////////////////////////////

            ///Task 10 - Word Position Finder
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();
            //Console.WriteLine("Enter a word:");
            //string word = Console.ReadLine();
            //int firstIndex = sentence.IndexOf(word);
            //int lastIndex = sentence.LastIndexOf(word);
            //if (firstIndex != -1) 
            //{
            //    Console.WriteLine("First occurrence of the word is at index: " + firstIndex); 
            //    Console.WriteLine("Last occurrence of the word is at index: " + lastIndex);
            //}
            //else
            //{
            //    Console.WriteLine("The word was not found in the sentence.");
            //}
            ///////////////////////////////////////////////////////

            ///Task 11 - One-Time Password (OTP) Generator
            Random random = new Random();
            int otp = random.Next(1000, 10000);

            Console.WriteLine("Otp has been sent:" + otp); // this line sent me an otp number

            int attempted = 0;

            while (attempted < 3)
            {
                try
                {
                    Console.WriteLine("Enter OTP");
                    int userInput = Convert.ToInt32(Console.ReadLine()); // i have to enter the number that they sent me.

                    if (userInput == otp)
                    {
                        Console.WriteLine("Verifide");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorecct code.");
                    }
                }
                catch
                {
                    Console.WriteLine("invalid input");
                }
                attempted++;
            }
            Console.WriteLine("verified failed");


        }
    }
}
