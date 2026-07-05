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
            Console.WriteLine("enter your full name");
            string name = Console.ReadLine();
            int length= name.Length;
            String lower=name.ToLower();
            String upper = name.ToUpper();
            Console.WriteLine("length is " + length);
            Console.WriteLine("lower case is " + lower);
            Console.WriteLine("upper case is " + upper);
            /////////////////////////////////////////////////////


        }
    }
}
