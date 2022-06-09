using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Bike
    {
        public string Message { get; set; }
        public void BikePrintMessage(string message)
        {
            Console.WriteLine("Message from Bike");
            Console.WriteLine(message);
            Message = message; 
        }
    }
}
