using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Exceptions
    {
        public const string InvalidDoughType = "Invalid type of dough.";
        public const string InvalidGramsRange = "Dough weight should be in the range [1..200].";
        public const string InvalidTopping = "Cannot place {0} on top of your pizza.";
        public const string InvalidToppingWeight ="{0} weight should be in the range [1..50].";
        public const string InvalidPizzaName = "Pizza name should be between 1 and 15 symbols.";
        public const string InvalidNumberOfTopping = "Number of toppings should be in range [0..10].";

    }
}
