using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class Customer
    {
        private string _firstName;
        private string _lastName;
        public string _accountNumber;

        //Constructors
        public Customer(string FirstName, string LastName, string AccountNumber)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _accountNumber = AccountNumber;
        }

        //Properties

        //Methods
        private string Print()
        {
            return _firstName + " " + _lastName + ", " + _accountNumber;
        }

        public override string ToString()
        {
            return Print();
        }
    }
}
