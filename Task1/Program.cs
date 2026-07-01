using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1
            //Personal Info Card    
            //Console.WriteLine("entre Your name ");
            //String name = Console.ReadLine();
            //Console.WriteLine("entre Your age ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("entre Your Height ");
            //double height = double.Parse(Console.ReadLine());
            //bool student = true;
            //Console.WriteLine("name " +name);
            //Console.WriteLine("age " + age);
            //Console.WriteLine("height " + height);
            //Console.WriteLine("student  " + student);

            ///task 2
            /// Rectangle Calculator
            /// 
            //Console.WriteLine("entre length  ");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("entre width  ");
            //double width = double.Parse(Console.ReadLine());
            //double Area = length * width;
            //double Perimeter = 2 * (length + width);
            //Console.WriteLine("Area: " + Area);
            //Console.WriteLine("Perimeter: " + Perimeter);

            //task 3
            //Even or Odd Checker
            //Console.WriteLine("entre even number  ");
            //int evennum = int.Parse(Console.ReadLine());

            //if (evennum % 2 == 0)
            //{
            //    Console.WriteLine(evennum + "number is even");
            //}
            //else
            //{
            //    Console.WriteLine(evennum + "number  is odd");
            //}

            // task 4
            // Voting Eligibility
            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("valid national ID ? (yes/no ");
            //string answare = Console.ReadLine();
            //bool hasValidId = (answare == "yes");
            //if (age >= 18 && hasValidId)
            //{
            //    Console.WriteLine("eligible to vote");
            //}
            //else
            //{
            //    Console.WriteLine(" no eligible to vote");
            //}
            //task 5
            // Grade Letter Lookup
            //Console.WriteLine("enter a single character representing a grade :");
            //String grade = Console.ReadLine();
            //switch (grade)
            //{
            //    case "A":
            //        Console.WriteLine("Excellent");
            //        break;
            //    case "B":
            //        Console.WriteLine("Very Good");
            //        break;
            //    case "C":
            //        Console.WriteLine("Good");
            //        break;
            //    case "D":
            //        Console.WriteLine("Pass");
            //        break;
            //    case "F":
            //        Console.WriteLine("Fail");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;

            // task 6
            //Temperature Converter

            Console.Write("Enter temperature in Celsius: ");
            double C = double.Parse(Console.ReadLine());
            double Fahrenheit = (C * 9 / 5) + 32;
            string weather;
            if (C < 10)
            {
                weather = "cold";
            }
            else if (C <= 30)
            {
                weather = "Mild";
            }
            else
            {
                weather = "Hot";
            }

            Console.WriteLine("Temperature in Fahrenheit: " + Fahrenheit);
            Console.WriteLine("Weather Classification: " + weather);






        
    }
    }
}
