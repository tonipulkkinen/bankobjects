﻿using System;
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
            Random rnd = new Random();
            Bank Bank = new Bank("DanskeBank");
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Hermanni", "Heiluja", Bank.NewAccount()));
            customers.Add(new Customer("Ihme", "Tyyppi", Bank.NewAccount()));
            customers.Add(new Customer("Joku", "Randomi", Bank.NewAccount()));

            Bank.NewAccountEvent(customers[0].AccountNumber, new AccountEvent(new DateTime(2017, 1, 1), 1000));
            Bank.NewAccountEvent(customers[1].AccountNumber, new AccountEvent(new DateTime(2017, 1, 1), 1000));
            Bank.NewAccountEvent(customers[2].AccountNumber, new AccountEvent(new DateTime(2017, 1, 1), 1000));

            for (int i = 0; i < 20; i++)
            {
                Bank.NewAccountEvent(customers[0].AccountNumber, new AccountEvent(new DateTime(2017, rnd.Next(1, 4), rnd.Next(1, 29)), Math.Round((rnd.NextDouble() * -75), 2)));
                Bank.NewAccountEvent(customers[1].AccountNumber, new AccountEvent(new DateTime(2017, rnd.Next(1, 4), rnd.Next(1, 29)), Math.Round((rnd.NextDouble() * -75), 2)));
                Bank.NewAccountEvent(customers[2].AccountNumber, new AccountEvent(new DateTime(2017, rnd.Next(1, 4), rnd.Next(1, 29)), Math.Round((rnd.NextDouble() * -75), 2)));
            }
            
            ShowBalance(Bank, customers[0]);
            ShowEvents(Bank.GetEvents(customers[0].AccountNumber, new DateTime(2017, 1, 1), new DateTime(2017, 4, 1)), customers[0]);

            ShowBalance(Bank, customers[1]);
            ShowEvents(Bank.GetEvents(customers[1].AccountNumber, new DateTime(2017, 1, 1), new DateTime(2017, 4, 1)), customers[1]);

            ShowBalance(Bank, customers[2]);
            ShowEvents(Bank.GetEvents(customers[2].AccountNumber, new DateTime(2017, 1, 1), new DateTime(2017, 4, 1)), customers[2]);
            Console.ReadKey();
        }
        static void ShowBalance(Bank Bank, Customer Customer)
        {
            var balance = Bank.GetBalance(Customer.AccountNumber);
            Console.WriteLine("{0}Balance: {1}",
                Customer.ToString(),
                balance);
        }
        static void ShowEvents(List<AccountEvent> events, Customer customer)
        {
            double CurrentBalance = 0;
            for (int i = 0; i < events.Count; i++)
            {
                CurrentBalance += events[i].Sum;
                Console.WriteLine("{0}\t{1}\t{2}", events[i].TimeStamp.ToShortDateString(), events[i].Sum, CurrentBalance);
            }
            Console.WriteLine("\n");
        }
    }
}