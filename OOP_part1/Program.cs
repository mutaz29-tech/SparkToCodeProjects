using System.ComponentModel;

namespace OOP_part1
{
    public class BankAccount
    {
        //properties
        public int AccountNumber {  get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        //methods
        //functions 
        public void Desposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance-=amount;
            }
        }
        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation()
        {
            Console.WriteLine("Name : " + HolderName);
            Console.WriteLine("Balance : " + Balance);
        }
    }
    class Student
    {
        //poroperties (store multi data /function)
        public int Grade { get; set;  }
        public string Name { get; set; }
        public string Addres  { get; set; }
        private string email { get; set; } //private property ,can only be accssed within class
        
        //methods (functions)
        public void Register (string Email)
        {
            email = Email;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object of the class
            Student s1 = new Student(); //declare variable or create an object
            //s1.Name = "Mutaz";
            //s1.Addres = "Alkhoud";
            //s1.Grade = 65;
            //s1.email = "mutaz@...."; //cannor access private property outside class
            s1.Register("mutaz@gmail");
            //Console.WriteLine("student name :" + s1.Name);
            //Console.WriteLine("student address :" + s1.Addres);
            //Console.WriteLine("student grade :" + s1.Grade);
            //Student s2 = new Student();
            //s2.Name = "Ahmed";
            //s2.Addres = "Seeb";
            //s2.Grade = 66;
            //access modifiers (public,private,proected,internal)
            /////
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1163;
            b1.HolderName = "Mutaz";
            b1.Balance = 120;

            double result = b1.CheckBalance();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 1342;
            b2.HolderName = "Ahmed";
            b2.Balance = 170;

            double result1 = b2.CheckBalance();
        }
    }
}
