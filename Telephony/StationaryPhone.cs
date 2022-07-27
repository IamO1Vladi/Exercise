using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    internal class StationaryPhone : IPhone
    {
        public void CallNumber(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
