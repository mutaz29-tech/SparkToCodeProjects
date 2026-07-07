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
            List<string> todoItems = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter task #{i + 1}: ");
                string task = Console.ReadLine();
                todoItems.Add(task);
            }
            Console.WriteLine(" To-Do List:");
            int number = 1;
            foreach (string task in todoItems)
            {
                Console.WriteLine($"{number}. {task}");
                number++;
            }

        }
    }
}
