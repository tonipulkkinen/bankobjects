using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountEvents;
        private double _balance;

        //Constructors
        public BankAccount(string AccountNumber, string AccountEvents, double Balance)
        {
            _accountNumber = AccountNumber;
            _accountEvents = AccountEvents;
            _balance = Balance;
        }

        //Properties

        //Methods
    }
}
