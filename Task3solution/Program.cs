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
            Console.Write("Enter the name (first time): ");
            string name1 = Console.ReadLine().Trim().ToUpper();
            Console.Write("Enter the name (second time): ");
            string name2 = Console.ReadLine().Trim().ToUpper();
            if (name1 == name2)
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("No Match");
            }


        }
    }
}
