using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        public const string EmptyNameMessage = "Name cannot be empty";
        public const string NegativeMoneyMessage = "Money cannot be negative";
        private string name;
        private decimal money;      

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name { get => name; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(EmptyNameMessage);
                }
                this.name = value;
            }
        }
        public decimal Money { get => money; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException(NegativeMoneyMessage);
                }
                this.money = value;
            }
        }

        public List<Product> Products { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append($"{Name} - ");

            if (Products.Count == 0)
            {
                output.Append("Nothing bought");
            }
            else
            {
                output.Append(string.Join(", ", Products));
            }

            return output.ToString().TrimEnd();
        }
    }
}
