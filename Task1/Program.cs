using System.Reflection.Metadata;

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
            Console.WriteLine("entre length  ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("entre width  ");
            double width = double.Parse(Console.ReadLine());
            double Area = length * width;
            double Perimeter = 2 * (length + width);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);


        }
    }
}
