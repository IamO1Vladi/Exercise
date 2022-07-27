using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    internal class Smartphone : IPhone
    {
        

        public void CallNumber(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public void BrowseWeb(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }
    }
}
