using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class AccountEvent
    {
        private string _timeStamp;
        private string _accountNumber;
        private double _sum;

        //Constructors
        public AccountEvent(string TimeStamp, string AccountNumber,double Sum)
        {
            _timeStamp = TimeStamp;
            _accountNumber = AccountNumber;
            _sum = Sum;
            BankAccount.NewEvent(_timeStamp, _accountNumber, _sum);
        }

        //Properties

        //Methods
    }
}
