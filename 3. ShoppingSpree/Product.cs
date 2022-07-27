using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private const string EmptyNameMessage = "Name cannot be empty";
        private const string NegativeMoneyMessage = "Money cannot be negative";
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(EmptyNameMessage);
                }
                this.name = value;
            }
        }
        public decimal Cost { get => cost; set 
            { 
                if(value< 0)
                {
                    throw new ArgumentException(NegativeMoneyMessage);
                }
                this.cost = value;
            } 
        }

        public override string ToString()
        {
            return Name.ToString().TrimEnd();
        }
    }
}
