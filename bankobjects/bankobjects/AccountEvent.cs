using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class AccountEvent
    {
        private readonly DateTime _timeStamp;
        private readonly double _sum;

        //Constructors
        public AccountEvent(DateTime TimeStamp, double Sum)
        {
            _timeStamp = TimeStamp;
            _sum = Sum;
        }

        //Properties
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
        }

        public double Sum
        {
            get { return _sum; }
        }

        //Methods
    }
}
