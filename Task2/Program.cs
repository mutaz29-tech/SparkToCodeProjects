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
            int secretNumber = 29; // my secret number is 29
            int gusss;
            int attempts = 0;

            do
            {
                Console.Write("Guess the secret number:");
                gusss = int.Parse(Console.ReadLine());
                attempts++;
                if (gusss > secretNumber)
                {
                    Console.WriteLine("Too high");
                }
                else if (gusss < secretNumber)
                {
                    Console.WriteLine("Too low.");
                }
                else
                {
                    Console.WriteLine($"you gussed the secret number");
                }
            } while (gusss != secretNumber);
            Console.WriteLine("It took you {attempts} attempts.");
        }
    }
}
    
