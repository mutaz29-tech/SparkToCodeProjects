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
        //static void DisplayMenu()
        //{
        //    Console.WriteLine(" MENU ");
        //    Console.WriteLine("1) Start");
        //    Console.WriteLine("2) Help");
        //    Console.WriteLine("3) Exit");
        //}
        //static void Main()
        //{
        //    DisplayMenu();
        //}
        //////////////////////////////////////////////////////////////

        ///Task 5 - Even or Odd Function
        //static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}
        //static void Main()
        //{
        //    Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());
        //    if (IsEven(number))
        //    {
        //        Console.WriteLine("Even");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Odd");
        //    }
        //}
        ////////////////////////////////////////////////////

        ///Task 6 - Rectangle Area & Perimeter Functions
        //static double CalculateArea(double length, double width)
        //{
        //    return length * width;
        //}
        //static double CalculatePerimeter(double length, double width)
        //{
        //    return 2 * (length + width);
        //}
        //static void Main()
        //{
        //    Console.Write("Enter the length: ");
        //    double length = double.Parse(Console.ReadLine());
        //    Console.Write("Enter the width: ");
        //    double width = double.Parse(Console.ReadLine());
        //    double area = CalculateArea(length, width);
        //    double perimeter = CalculatePerimeter(length, width);
        //    Console.WriteLine("Area = " + area);
        //    Console.WriteLine("Perimeter = " + perimeter);
        //}
        //////////////////////////////////////////////////////////////////


        ///Task 7 - Grade Letter Function
        //static string GradeLetter(int score)
        //{
        //    if (score >= 90)
        //    {
        //        return "A";
        //    }
        //    else if (score >= 80)
        //    {
        //        return "B";
        //    }
        //    else if (score >= 70)
        //    {
        //        return "C";
        //    }
        //    else if (score >= 60)
        //    {
        //        return "D";
        //    }
        //    else
        //    {
        //        return "F";
        //    }
        //}
        //static void Main()
        //{
        //    Console.Write("Enter your score: ");
        //    int score = int.Parse(Console.ReadLine());

        //    string grade = GradeLetter(score);

        //    Console.WriteLine("Grade Letter: " + grade);
        //}
        //////////////////////////////////////////////////////////////////

        ///Task 8 - Countdown Function
        //static void Count(int startNumber)
        //{
        //    for (int i = startNumber; i >= 1; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //static void Main()
        //{
        //    Console.Write("Enter a starting number: ");
        //    int startNumber = int.Parse(Console.ReadLine());
        //    Count(startNumber);
        //}
        ////////////////////////////////////////////////////////////////

        ///Task 9 - Overloaded Multiply Function
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        static void Main()
        {
            int result1 = Multiply(4, 5);
            double result2 = Multiply(2.5, 3.2);
            int result3 = Multiply(2, 3, 4);
            Console.WriteLine("Multiply(int, int): " + result1);
            Console.WriteLine("Multiply(double, double): " + result2);
            Console.WriteLine("Multiply(int, int, int): " + result3);
        }


    }
}
