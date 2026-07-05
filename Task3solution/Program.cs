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
            Console.WriteLine("enter number");
            int number = int.Parse(Console.ReadLine());
            double pow = Math.Pow(number,2);
            double sqrt = Math.Sqrt(number);
            Console.WriteLine("power is " + pow);
            Console.WriteLine("square root is " + sqrt);
        }
    }
}
