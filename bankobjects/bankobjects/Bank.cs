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
        public List<string> _accounts = new List<string>();

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
                sb.Append(r.Next(0, 10));
            }
            _accounts.Add(sb.ToString());
            return sb.ToString();
        }
    }
}
