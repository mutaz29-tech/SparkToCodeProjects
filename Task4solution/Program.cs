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
        //static int Multiply(int a, int b)
        //{
        //    return a * b;
        //}
        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}
        //static int Multiply(int a, int b, int c)
        //{
        //    return a * b * c;
        //}
        //static void Main()
        //{
        //    int result1 = Multiply(4, 5);
        //    double result2 = Multiply(2.5, 3.2);
        //    int result3 = Multiply(2, 3, 4);
        //    Console.WriteLine("Multiply(int, int): " + result1);
        //    Console.WriteLine("Multiply(double, double): " + result2);
        //    Console.WriteLine("Multiply(int, int, int): " + result3);
        //}
        ////////////////////////////////////////////////////////////////////////////

        ///Task 10 - Overloaded Area Calculator
        //static double CalculateArea(double side)
        //{
        //    return side * side;
        //}
        //static double CalculateArea(double length, double width)
        //{
        //    return length * width;
        //}
        //static void Main()
        //{
        //    Console.WriteLine("Choose a shape:");
        //    Console.WriteLine("1. Square");
        //    Console.WriteLine("2. Rectangle");

        //    Console.Write("Enter your choice: ");
        //    int choice = int.Parse(Console.ReadLine());

        //    if (choice == 1)
        //    {
        //        Console.Write("Enter the side length: ");
        //        double side = double.Parse(Console.ReadLine());

        //        double area = CalculateArea(side);

        //        Console.WriteLine("Area of the square: " + area);
        //    }
        //    else if (choice == 2)
        //    {
        //        Console.Write("Enter the length: ");
        //        double length = double.Parse(Console.ReadLine());
        //        Console.Write("Enter the width: ");
        //        double width = double.Parse(Console.ReadLine());
        //        double area = CalculateArea(length, width);
        //        Console.WriteLine("Area of the rectangle: " + area);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid choice.");
        //    }
        //}
        /////////////////////////////////////////////////////////////////////

        //Task 11 - Function-Based Calculator
        //// Add
        //static double Add(double num1, double num2)
        //{
        //    return num1 + num2;
        //}
        //// Sub
        //static double Subtract(double num1, double num2)
        //{
        //    return num1 - num2;
        //}
        //// Multipli
        //static double MultiplyNumbers(double num1, double num2)
        //{
        //    return num1 * num2;
        //}
        //// Division with try-catch
        //static double DivideNumbers(double num1, double num2)
        //{
        //    try
        //    {
        //        if (num2 == 0)
        //        {
        //            throw new DivideByZeroException();
        //        }

        //        return num1 / num2;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Error: Cannot divide by zero.");
        //        return 0;
        //    }
        //}
        //// Display result
        //static void DisplayResult(string operationName, double result)
        //{
        //    Console.WriteLine($"\n{operationName} Result = {result}\n");
        //}
        //static void Main()
        //{
        //    bool running = true;

        //    while (running)
        //    {
        //        Console.WriteLine("CALCULATOR MENU");
        //        Console.WriteLine("1. Add");
        //        Console.WriteLine("2. Subtract");
        //        Console.WriteLine("3. Multiply");
        //        Console.WriteLine("4. Divide");
        //        Console.WriteLine("5. Exit");
        //        Console.Write("Choose an option: ");

        //        int choice = int.Parse(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                Console.Write("Enter first number: ");
        //                double addNum1 = double.Parse(Console.ReadLine());

        //                Console.Write("Enter second number: ");
        //                double addNum2 = double.Parse(Console.ReadLine());

        //                DisplayResult("Addition", Add(addNum1, addNum2));
        //                break;

        //            case 2:
        //                Console.Write("Enter first number: ");
        //                double subNum1 = double.Parse(Console.ReadLine());

        //                Console.Write("Enter second number: ");
        //                double subNum2 = double.Parse(Console.ReadLine());

        //                DisplayResult("Subtraction", Subtract(subNum1, subNum2));
        //                break;

        //            case 3:
        //                Console.Write("Enter first number: ");
        //                double mulNum1 = double.Parse(Console.ReadLine());

        //                Console.Write("Enter second number: ");
        //                double mulNum2 = double.Parse(Console.ReadLine());

        //                DisplayResult("Multiplication", MultiplyNumbers(mulNum1, mulNum2));
        //                break;

        //            case 4:
        //                Console.Write("Enter first number: ");
        //                double divNum1 = double.Parse(Console.ReadLine());

        //                Console.Write("Enter second number: ");
        //                double divNum2 = double.Parse(Console.ReadLine());

        //                DisplayResult("Division", DivideNumbers(divNum1, divNum2));
        //                break;

        //            case 5:
        //                running = false;
        //                Console.WriteLine("Exiting calculator...");
        //                break;

        //            default:
        //                Console.WriteLine("Invalid option. Please try again.\n");
        //                break;
        //        }
        //    }
        //}
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///Task 12 - Student Report Card Generator
        static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3;
        }
        static string GradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        // Prints the report card
        static void PrintReportCard(string studentName, double average, string gradeLetter)
        {
            Console.WriteLine("REPORT CARD");
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Average Score: " + average.ToString("F2"));
            Console.WriteLine("Grade Letter: " + gradeLetter);
        }
        static void Main()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter score for Subject 1: ");
            double score1 = double.Parse(Console.ReadLine());
            Console.Write("Enter score for Subject 2: ");
            double score2 = double.Parse(Console.ReadLine());
            Console.Write("Enter score for Subject 3: ");
            double score3 = double.Parse(Console.ReadLine());
            double average = CalculateAverage(score1, score2, score3);
            string gradeLetter = GradeLetter(average);
            PrintReportCard(studentName, average, gradeLetter);
        }



    }
}
