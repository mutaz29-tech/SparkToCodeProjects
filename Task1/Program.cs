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

            //Console.Write("Enter temperature in Celsius: ");
            //double C = double.Parse(Console.ReadLine());
            //double Fahrenheit = (C * 9 / 5) + 32;
            //string weather;
            //if (C < 10)
            //{
            //    weather = "cold";
            //}
            //else if (C <= 30)
            //{
            //    weather = "Mild";
            //}
            //else
            //{
            //    weather = "Hot";
            //}

            //Console.WriteLine("Temperature in Fahrenheit: " + Fahrenheit);
            //Console.WriteLine("Weather Classification: " + weather);

            // task 7 
            //Movie Ticket Pricing
            //Console.WriteLine("enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //string category;
            //double price;
            //if (age > 0 && age <= 12)
            //{
            //    category = "Children";
            //    price = 2.000;
            //}
            //else if (age <= 59)
            //{
            //    category = "Adults";
            //    price = 5.000;
            //}
            //else
            //{
            //    category = "Seniors";
            //    price = 3.000;
            //}

            //Console.WriteLine("Category: " + category);
            //Console.WriteLine("Ticket Price: " + price + " OMR");

            //task 8
            //Restaurant Bill with Membership Discount
            //Console.WriteLine("total bill amount ");
            //double billamount = double.Parse(Console.ReadLine());
            //Console.WriteLine("are a loyalty member (yes/no)");
            //string loyalmm= Console.ReadLine();
            //bool ismember = (loyalmm == "yes");
            //double discount = 0;

            //if (billamount > 20 && ismember) {
            //    discount = billamount * 0.15;
            //}
            //double finalAmount = billamount - discount;

            //Console.WriteLine(" Bill Summary");
            //Console.WriteLine("Original Bill: " + billamount + " OMR");
            //Console.WriteLine("Discount: " + discount + " OMR");
            //Console.WriteLine("Final Amount to Pay: " + finalAmount + " OMR");

            //task 9 
            // Day Name Finder
            //Console.WriteLine("enter a number from 1 to 7");
            //int daynumber= int.Parse(Console.ReadLine());
            //switch (daynumber) {
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //     case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //     case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //      case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //      case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;}

            //task 10 
            //Mini Calculator

            //Console.Write("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter an operator (+, -, *, /, %): ");
            //char op = char.Parse(Console.ReadLine());

            //switch (op)
            //{
            //    case '+':
            //        Console.WriteLine("Result: " + (num1 + num2));
            //        break;

            //    case '-':
            //        Console.WriteLine("Result: " + (num1 - num2));
            //        break;

            //    case '*':
            //        Console.WriteLine("Result: " + (num1 * num2));
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("Result: " + (num1 / num2));
            //        }

            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;

            //    case '%':
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("Result: " + (num1 % num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by zero");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator");
            //        break;
            //}

            //task 11
            // Loan Eligibility System

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.Write("Enter your monthly income (OMR): ");
            //double income = double.Parse(Console.ReadLine());
            //Console.Write("Do you have an existing loan? (yes/no): ");
            //string answer =Console.ReadLine();
            //bool ExistingLoan = (answer == "yes");

            //if (age >= 21 && age <= 60 && income >= 400 && !ExistingLoan)
            //{
            //    Console.WriteLine("Eligible for the loan.");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible for the loan.");

            //    if (age < 21 || age > 60)
            //    {
            //        Console.WriteLine("Reason: Age is out of the eligible range (21-60).");
            //    }
            //    else if (income < 400)
            //    {
            //        Console.WriteLine("Reason: Monthly income is too low.");
            //    }

            //    else if (ExistingLoan)
            //    {
            //        Console.WriteLine("Reason: Applicant has an existing loan.");

            //    }
            //}

            //task 12 
            //Shipping Cost Calculator
            //Console.Write("Enter region code (A = Local, B = National, C = International): ");
            //char region = char.Parse(Console.ReadLine());

            //Console.Write("Enter package weight (kg): ");
            //double weight = double.Parse(Console.ReadLine());

            //double baseCost = 0;
            //double extraCharge = 0;

            //switch (region)
            //{
            //    case 'A':
            //        baseCost = 1.000;

            //        if (weight > 10)
            //            extraCharge = 5.000;
            //        else if (weight > 5)
            //            extraCharge = 2.000;

            //        Console.WriteLine("Region: Local");
            //        Console.WriteLine("Base Cost: " + baseCost.ToString("F3") + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge.ToString("F3") + " OMR");
            //        Console.WriteLine("Total Shipping Cost: " + (baseCost + extraCharge).ToString("F3") + " OMR");
            //        break;

            //    case 'B':
            //        baseCost = 3.000;

            //        if (weight > 10)
            //            extraCharge = 5.000;
            //        else if (weight > 5)
            //            extraCharge = 2.000;

            //        Console.WriteLine("Region: National");
            //        Console.WriteLine("Base Cost: " + baseCost + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge + " OMR");
            //        Console.WriteLine("Total Shipping Cost: " + (baseCost + extraCharge)+ " OMR");
            //        break;

            //    case 'C':
            //        baseCost = 7.000;

            //        if (weight > 10)
            //            extraCharge = 5.000;
            //        else if (weight > 5)
            //            extraCharge = 2.000;

            //        Console.WriteLine("Region: International");
            //        Console.WriteLine("Base Cost: " + baseCost + " OMR");
            //        Console.WriteLine("Extra Charge: " + extraCharge+ " OMR");
            //        Console.WriteLine("Total Shipping Cost: " + (baseCost + extraCharge)+ " OMR");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid region");
            //        break;
            //}


            //task 13
            //Triangle Type Classifier

            Console.Write("Enter the first side: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second side: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third side: ");
            double side3 = double.Parse(Console.ReadLine());
            //valid triangle
            if ((side1 + side2 > side3) &&
                        (side1 + side3 > side2) &&
                        (side2 + side3 > side1))
            {
                Console.WriteLine("The sides form a valid triangle.");

                if (side1 == side2 && side2 == side3)
                {
                    Console.WriteLine("Triangle Type: Equilateral");
                }
                else
                {
                    if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Triangle Type: Isosceles");
                    }

                    else
                    {
                        Console.WriteLine("Triangle Type: Scalene");
                    }
                }
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }
        
















    }
}
}
