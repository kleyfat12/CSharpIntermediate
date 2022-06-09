using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Car
    {
        public string Message { get; set; }
        public void CarPrintMessage(string message)
        {
            Console.WriteLine("Message from Car");
            Console.WriteLine(message);
            Message = message;
        }
    }
}
