using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class Bank
    {
        private ArrayList sinks = new ArrayList();
        public Bank(string name, double savings)
        {
            Name = name;
            Savings = savings;
        }

        public void AddSink(BankSink sink)
        {
            if (sink != null)
            {
                sinks.Add(sink);
            }
        }

        public void RemoveSink(BankSink sink)
        {
            if (sinks.Contains(sink))
            {
                sinks.Remove(sink);
            }
        }

        public string Name { get; set; }
        public double Savings { get; set; }

        public void WithdrawMoney(double money)
        {
            if (Savings - money < 0)
            {
                Console.WriteLine("It is not possible to withdraw more money than there is in the bank");
                return;
            }
            Savings -= money;
            Console.WriteLine("Money withdrawn: " + money);
            Console.WriteLine("Savings remaining: " + Savings);
            if (Savings < 1000)
            {
                foreach (BankSink sink in sinks)
                {
                    sink.LowSavingEvent(Savings);
                }
            }
        }

    }
}
