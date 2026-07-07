namespace Csharpseesion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //collection (data structures) pf var
            //array
            int grade;
            int[] grades= new int [4]; //array to hold 4 var
            grades[0] = 88; // assign var for first value 
            grades[1] = 90;
            grades[2] = 70;
            grades[3] = 80;
            Console.WriteLine(grades);

            // list 
            List<int> stdgrades = new List<int>(); //declare  list to hold grades
            stdgrades.Add(78); //add values in list 
            stdgrades.Add(66);
            stdgrades.Add(100);
            stdgrades.Add(99);

            stdgrades[2] = 55; //reassign or change the value of the third element of the list
            Console.WriteLine(stdgrades[2]); //print the value of the third element of the list

            Console.WriteLine("enter a grade: ");
            stdgrades.Add(int.Parse(Console.ReadLine()));
        }
    }
}
