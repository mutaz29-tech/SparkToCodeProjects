namespace Task5soluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array

            //int[] grades = new int[5];
            //// Input grades using a for loop
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write($"Enter grade #{i + 1}: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}
            //// Print grades using a foreach loop
            //Console.WriteLine(" Student Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //////////////////////////////////////////////////

            ///Task 2 - Dynamic To-Do List
            //List<string> todoItems = new List<string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter task #{i + 1}: ");
            //    string task = Console.ReadLine();
            //    todoItems.Add(task);
            //}
            //Console.WriteLine(" To-Do List:");
            //int number = 1;
            //foreach (string task in todoItems)
            //{
            //    Console.WriteLine($"{number}. {task}");
            //    number++;
            //}
            //////////////////////////////////////////////////////////////

            ///Task 3 - Browsing History Stack
            //Stack<string> browserHistory = new Stack<string>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter URL #{i + 1}: ");
            //    string url = Console.ReadLine();
            //    browserHistory.Push(url);
            //}
            //browserHistory.Pop();
            //if (browserHistory.Count > 0)
            //{
            //    Console.WriteLine($" After pressing Back, you land on: {browserHistory.Peek()}");
            //}
            //else
            //{
            //    Console.WriteLine(" No pages left in the browser history.");
            //}
            //////////////////////////////////////////////////////////////////////////////////

            ///Task 4 - Customer Service Queue
            //Queue<string> customers = new Queue<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Enter customer #{i + 1}: ");
            //    string name = Console.ReadLine();
            //    customers.Enqueue(name);
            //}
            //string servedCustomer = customers.Dequeue();
            //Console.WriteLine($"\nServed customer: {servedCustomer}");
            ///////////////////////////////////////////////////////////////////////////

            ///Task 5 - Array Grade Range

            int[] grades = new int[5];
            int sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade #{i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            // Sort the array
            Array.Sort(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Length;
            // Print results
            Console.WriteLine(" Results:");
            Console.WriteLine($"Lowest Grade: {grades[0]}");
            Console.WriteLine($"Highest Grade: {grades[grades.Length - 1]}");
            Console.WriteLine($"Average Grade: {average:F2}");


        }
    }
}
