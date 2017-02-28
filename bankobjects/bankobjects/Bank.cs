using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class Bank
    {
        private string _name;
        private List<BankAccount> _accounts;
        private Random r = new Random();

        //Constructors
        public Bank(string Name)
        {
            _name = Name;
            _accounts = new List<BankAccount>();
        }

        //Properties

        //Methods
        public string NewAccount()
        {
            string accountNumber = "FI";
            
            for (int i = 0; i < 16; i++)
            {
                accountNumber += r.Next(0, 10).ToString();
            }
            _accounts.Add(new BankAccount(accountNumber));
            return accountNumber;
        }
        public bool NewAccountEvent(string accountNumber, AccountEvent Event)
        {
            return (from account in _accounts
                    where account.AccountNumber == accountNumber
                    select account).First().AddEvent(Event);
        }
        public double GetBalance(string AccountNumber)
        {
            return (from account in _accounts
                    where account.AccountNumber == AccountNumber
                    select account).FirstOrDefault().Balance;
        }
    }
}
