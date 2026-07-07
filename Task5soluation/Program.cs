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

            //int[] grades = new int[5];
            //int sum = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write($"Enter grade #{i + 1}: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}
            //// Sort the array
            //Array.Sort(grades);
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //}
            //double average = (double)sum / grades.Length;
            //// Print results
            //Console.WriteLine(" Results:");
            //Console.WriteLine($"Lowest Grade: {grades[0]}");
            //Console.WriteLine($"Highest Grade: {grades[grades.Length - 1]}");
            //Console.WriteLine($"Average Grade: {average:F2}");
            //////////////////////////////////////////////////////////////////////

            ///Task 6 - Filtered Shopping List

            //List<string> shoppingList = new List<string>();
            //string item = "";
            //while (item.ToLower() != "done")
            //{
            //    Console.Write("Enter an item (or type 'done' to finish): ");
            //    item = Console.ReadLine();
            //    if (item.ToLower() != "done")
            //    {
            //        shoppingList.Add(item);
            //    }
            //}
            //Console.WriteLine("\nShopping List Before Removal:");
            //foreach (string shoppingItem in shoppingList)
            //{
            //    Console.WriteLine("- " + shoppingItem);
            //}
            //Console.Write("\nEnter an item to remove: ");
            //string itemToRemove = Console.ReadLine();
            //shoppingList.Remove(itemToRemove);
            //// Print the list after removal
            //Console.WriteLine("\nShopping List After Removal:");
            //foreach (string shoppingItem in shoppingList)
            //{
            //    Console.WriteLine("- " + shoppingItem);
            //}
            ////////////////////////////////////////////////////////

            ///Task 7 - High Score Podium
            //List<int> scores = new List<int>();
            //// Ask the user to enter 5 scores
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter score #{i + 1}: ");
            //    scores.Add(int.Parse(Console.ReadLine()));
            //}
            //// Sort in ascending order, then reverse to descending order
            //scores.Sort();
            //scores.Reverse();
            //// Print the top 3 scores as a podium
            //Console.WriteLine(" Top 3 Scores ");
            //Console.WriteLine($"1st place: {scores[0]}");
            //Console.WriteLine($"2nd place: {scores[1]}");
            //Console.WriteLine($"3rd place: {scores[2]}");
            //////////////////////////////////////////////////////////

            ///Task 8 - Undo Last Action
            Stack<string> actions = new Stack<string>();
            string action = "";
            while (action.ToLower() != "stop")
            {
                Console.Write("Enter an action (or type 'stop' to finish): ");
                action = Console.ReadLine();

                if (action.ToLower() != "stop")
                {
                    actions.Push(action);
                }
            }
            // Simulate Undo twice
            Console.WriteLine("\nUndoing the last two actions:");
            if (actions.Count > 0)
            {
                Console.WriteLine("Undone: " + actions.Pop());
            }

            if (actions.Count > 0)
            {
                Console.WriteLine("Undone: " + actions.Pop());
            }
            // Print remaining actions
            Console.WriteLine("\nActions remaining in the stack:");
            foreach (string remainingAction in actions)
            {
                Console.WriteLine("- " + remainingAction);
            }


        }
    }
}
