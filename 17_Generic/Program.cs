using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter account");
            //int accountInt = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Enter name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter balance");
            //int balance = Convert.ToInt32(Console.ReadLine());

            //BankAccount<int> account1 = new BankAccount<int>(accountInt, name, balance); //{ Account=accountInt, Name=name, Balance=balance};
            // BankAccount<string> account = new BankAccount<string>() { Account = "A001", Name = "CDA", Balance = 200};

           // Console.WriteLine(account1.GetInfo());

           // Console.WriteLine("Enter string account");
           // string accountString = Console.ReadLine();
            //Console.WriteLine("Enter name");
            //name = Console.ReadLine();
           // Console.WriteLine("Enter balance");
          //  balance = Convert.ToInt32(Console.ReadLine());

            //BankAccount<string> account2 = new BankAccount<string>(accountString, name, balance); //{ Account = accountString, Name = name, Balance = balance };
       
            BankAccount<int> account = new BankAccount<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            BankAccount<string> account = new BankAccount<string>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());

            Console.ReadKey();
        }
    }
}
