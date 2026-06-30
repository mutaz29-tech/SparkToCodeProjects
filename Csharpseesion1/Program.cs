namespace Csharpseesion1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program to show welcome message 
            //Console.Write(" enter your name: ");
            //string username = Console.ReadLine();

            //Console.Write(" enter your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write(" enter your Salary: ");
            //float salary = float.Parse(Console.ReadLine());

            //Console.WriteLine("Hello " + username + " welcome to spark to code");

            ///
            //Console.WriteLine("enter first number ");
            //float firstnumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter second number ");
            //float secondnumber = float.Parse(Console.ReadLine());

            //float add = firstnumber + secondnumber;
            //float sub = firstnumber - secondnumber;
            //float multi = firstnumber * secondnumber;
            //float divv = firstnumber / secondnumber;
            //float reimainder = firstnumber % secondnumber;

            //Console.WriteLine("add result " +add);
            //Console.WriteLine("sub result " + sub);
            //Console.WriteLine("multi result " + multi);
            //Console.WriteLine("divv result " + divv);
            //Console.WriteLine("reminder result " + reimainder);

            //bool result= firstnumber > secondnumber;
            //Console.WriteLine("rsult" +result);

            //Console.WriteLine("enter your dagree: ");
            //float degree = float.Parse(Console.ReadLine());
            //if (degree < 50)
            //{
            //    Console.WriteLine("You faild");
            //}
            //else if (degree >= 50 && degree < 60)
            //{
            //    Console.WriteLine("you pass with D");
            //}
            //else if (degree >= 60 && degree < 70)
            //{
            //    Console.WriteLine("ypu passde with garde :c");
            //}
            //else if (degree>=70 && degree < 80)
            //{
            //    Console.WriteLine("ypu passde with grade :b");
            //}

            //else
            //{
            //    Console.WriteLine("you enter wornge number ");
            //}
            /////
            Console.WriteLine("welcome to main menu");
            Console.WriteLine("1.Depoist");
            Console.WriteLine("2.withdraw");
            Console.WriteLine("3.Balnce check");
            Console.WriteLine("please choose one option :");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Depoist");
                    break;
                case 2:
                    Console.WriteLine("withdraw");
                    break;
                case 3:
                    Console.WriteLine("Balnce check");
                    break;
                default:
                    Console.WriteLine("please choose one option");
                    break;


            }



        }
    }
}
