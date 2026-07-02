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
            Console.WriteLine("Enter positive whole number:");
            int pnum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= pnum; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is :" + sum);
            /////////////////////

        }
    }
}
