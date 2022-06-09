using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    class BankSink : IBankEvents
    {
        public void LowSavingEvent(double saving)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Low saving. Savings ramaining: " + saving);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
