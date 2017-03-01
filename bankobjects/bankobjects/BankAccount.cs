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
        private List<AccountEvent> _accountEvents = new List<AccountEvent>();
        private double _balance;

        //Constructors
        public BankAccount(string AccountNumber)
        {
            _accountNumber = AccountNumber;
        }

        //Properties
        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        //Methods
        public bool AddEvent(AccountEvent Event)
        {
            bool accept = false;
            _accountEvents.Add(Event);
            double currentBalance = _balance;
            if (_accountEvents.Last().Equals(Event))
            {
                _balance += Event.Sum;
            }
            if (_balance - Event.Sum == currentBalance)
            {
                accept = true;
            }
            return accept;
        }
        public List<AccountEvent> GetEventsTimeSpan(DateTime start, DateTime end)
        {
            List<AccountEvent> list = (from accountevent in _accountEvents
                                       where accountevent.TimeStamp >= start && accountevent.TimeStamp <= end
                                       orderby accountevent.TimeStamp
                                       select accountevent).ToList();
            return list;
        }
    }
}
