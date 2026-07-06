namespace Task4solution
{
    internal class Program
    {
        ///Task 1 - Personalized Welcome Function

        static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome, {name}! We are glad to have you here.");
        }

        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            PrintWelcome(name);
        }

    }
}
