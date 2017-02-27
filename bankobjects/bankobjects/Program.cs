using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankobjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bank Bank1 = new Bank("DanskeBank");
            Customer Customer1 = new Customer("Hermanni", "Heiluja", Bank1.NewAccount());
            Customer Customer2 = new Customer("Ihme", "Tyyppi", Bank1.NewAccount());
            Customer Customer3 = new Customer("Joku", "Randomi", Bank1.NewAccount());
        }
    }
}
