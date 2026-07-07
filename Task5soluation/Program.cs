namespace Task5soluation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array

            int[] grades = new int[5];
            // Input grades using a for loop
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grade #{i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
            // Print grades using a foreach loop
            Console.WriteLine(" Student Grades:");

            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }

        }
    }
}
