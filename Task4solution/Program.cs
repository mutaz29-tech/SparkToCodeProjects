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
        //static int Square(int number)
        //{
        //    return number * number;
        //}
        //static void Main()
        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());
        //    int result = Square(number);
        //    Console.WriteLine("The square is: " + result);
        //}
        /////////////////////////////////////////////////////////

        ///Task 3 - Celsius to Fahrenheit Function
        //static double CelsiusToFahrenheit(double celsius)
        //{
        //    return (celsius * 9 / 5) + 32;
        //}
        //static void Main()
        //{
        //    Console.Write("Enter temperature in Celsius: ");
        //    double celsius = double.Parse(Console.ReadLine());

        //    double fahrenheit = CelsiusToFahrenheit(celsius);

        //    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        //}
        /////////////////////////////////////////////////////////////////////////////////////

        ///Task 4 - Fixed Menu Display Function
        static void DisplayMenu()
        {
            Console.WriteLine(" MENU ");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }
        static void Main()
        {
            DisplayMenu();
        }


    }
}
