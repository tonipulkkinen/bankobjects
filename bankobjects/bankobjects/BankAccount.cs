using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class BankAccount
    {
        public string _accountNumber;
        private List<string> _accountEvents = new List<string>();
        public double _balance;

        //Constructors
        public BankAccount(string AccountNumber)
        {
            _accountNumber = AccountNumber;
        }

        //Properties

        //Methods
        public void NewEvent(string TimeStamp, string AccountNumber, double Sum)
        {
            if(AccountNumber == _accountNumber)
            {
                _accountEvents.Add(TimeStamp + ", " + Sum);
                _balance += Sum;
            }
        }
    }
}
