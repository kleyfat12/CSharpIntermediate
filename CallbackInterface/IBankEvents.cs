using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackInterface
{
    interface IBankEvents
    {
        public void LowSavingEvent(double saving);
    }
}
