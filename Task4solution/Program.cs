namespace Task4solution
{
    internal class Program
    {
        ///Task 1 - Personalized Welcome Function

        //static void PrintWelcome(string name)
        //{
        //    Console.WriteLine($"Welcome, {name}! We are glad to have you here.");
        //}

        //static void Main()
        //{
        //    Console.Write("Enter your name: ");
        //    string name = Console.ReadLine();

        //    PrintWelcome(name);
        //}
        ////////////////////////////////////////////

        ///Task 2 - Square Number Function
        static int Square(int number)
        {
            return number * number;
        }
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int result = Square(number);
            Console.WriteLine("The square is: " + result);
        }


    }
}
