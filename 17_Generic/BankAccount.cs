using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _17_Generic
{
    internal class BankAccount<T>
    {
        public T Account { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; } 
        
       
       // public BankAccount(T account, string name, int balance )
       // {
        //    Account = account;
         //   Name = name;
         //   Balance = balance;
      //  }

        public string GetInfo()
        { 
            return $"{Account} {Name} {Balance}"; 
        }

        public void Input() 
        {

            Console.WriteLine("Enter account");
            Account = (T) Convert.ChangeType (Console.ReadLine(), typeof (T));
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter balance");
            Balance = Convert.ToInt32(Console.ReadLine());

        }
    }
}
