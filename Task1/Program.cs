namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1
            //Personal Info Card    
            Console.WriteLine("entre Your name ");
            String name = Console.ReadLine();
            Console.WriteLine("entre Your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("entre Your Height ");
            double height = double.Parse(Console.ReadLine());
            bool student = true;
            Console.WriteLine("name " +name);
            Console.WriteLine("age " + age);
            Console.WriteLine("height " + height);
            Console.WriteLine("student  " + student);



        }
    }
}
