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
        private string _accountNumber;

        //Constructors
        public Customer(string FirstName, string LastName, string AccountNumber)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _accountNumber = AccountNumber;
        }

        //Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        //Methods
        public override string ToString()
        {
            return string.Format("{0, -10} {1, -10}{2, -20}",
                _firstName,
                _lastName,
                _accountNumber);
        }
    }
}
