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
        private List<string> _accounts;

        //Constructors
        public Bank(string Name)
        {
            _name = Name;
        }

        //Properties

        //Methods
        public void AddAccount(string Account)
        {
            _accounts.Add(Account);
        }
        public string NewAccount()
        {
            StringBuilder sb = new StringBuilder("FI");
            int i;
            Random r = new Random();
            for (i = 0; i < 16; i++)
            {
                sb.Append(r.Next(1, 10));
            }
            return sb.ToString();
        }
    }
}
