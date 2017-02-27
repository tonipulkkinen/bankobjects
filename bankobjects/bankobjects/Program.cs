using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class Program
    {
         public void Main(string[] args)
        {
            Bank Bank1 = new Bank("DanskeBank");

            Customer Customer1 = new Customer("Hermanni", "Heiluja", Bank1.NewAccount());
            BankAccount Account1 = new BankAccount(Customer1._accountNumber);
            AccountEvent Event1 = new AccountEvent(DateTime.Today.ToString(), Account1._accountNumber, 500);

            Customer Customer2 = new Customer("Ihme", "Tyyppi", Bank1.NewAccount());
            BankAccount Account2 = new BankAccount(Customer2._accountNumber);
            AccountEvent Event2 = new AccountEvent(DateTime.Today.ToString(), Account2._accountNumber, 300);

            Customer Customer3 = new Customer("Joku", "Randomi", Bank1.NewAccount());
            BankAccount Account3 = new BankAccount(Customer3._accountNumber);
            AccountEvent Event3 = new AccountEvent(DateTime.Today.ToString(), Account3._accountNumber, 1000);
            
            Console.WriteLine(Customer1.ToString() + ", " + Account1._balance);
            Console.WriteLine(Customer2.ToString() + ", " + Account2._balance);
            Console.WriteLine(Customer3.ToString() + ", " + Account3._balance);
            Console.ReadKey();
        }
    }
}