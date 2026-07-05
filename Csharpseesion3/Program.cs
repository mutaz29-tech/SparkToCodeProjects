namespace Csharpseesion3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //bult in function 
            //Math.Cos(90);
            //double re= Math.Pow(2, 3);
            //Console.WriteLine(re);
            //Console.Clear();
            //////////////////////
            //Console.WriteLine("enter number ");
            //float usrinp = float.Parse(Console.ReadLine());
            //double re =Math.Cos(usrinp);
            //Console.WriteLine(re);
            /////////////////
            //Console.WriteLine("enter bas number  ");
            //float bas = float.Parse(Console.ReadLine());
            //Console.WriteLine("enter power number  ");
            //float pow = float.Parse(Console.ReadLine());
            //double r = Math.Pow(bas,pow);
            //Console.WriteLine(r);
            /////////////////////////////////////////////////////
            //DateTime currenttiming = DateTime.Now;
            //Console.WriteLine(currenttiming);
            //DateTime today = DateTime.Today;
            //Console.WriteLine(today);


            //DateTime startsub = DateTime.Today;
            //DateTime endsub= startsub.AddDays(30);
            //Console.WriteLine("your subcription ends on : " + endsub);
            ////////////////////////////
            ///string function format
            //string word = "hello world !";
            //int length= word.Length;
            //String sub =word.Substring(7, 5);
            //String lower=word.ToLower();
            //String upper= word.ToUpper();
            //Console.WriteLine(length);
            //Console.WriteLine(sub);
            //Console.WriteLine(lower);
            //Console.WriteLine(upper);

            string name = "Ahmed";

            Console.WriteLine("enter any name");
            string input = Console.ReadLine();

            if (input == name)
            {
                Console.WriteLine("welcome to app, succesfull logain");
            }
            else
            {
                Console.WriteLine("invalid name , try again");
            }

        }
    }
}
