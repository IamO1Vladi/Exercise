using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    internal interface IBuyer
    {
        public string Name { get; }
        public int BuyFood();

        public int Food { get; }

    }
}
