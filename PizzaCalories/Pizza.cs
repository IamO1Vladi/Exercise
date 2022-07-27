using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    internal class Pizza
    {

        //        A Pizza should have a name, some toppings, and dough.
        //        Make use of the two classes you made earlier.
        //        In addition, a Pizza should have public getters for its name, the number of toppings, and the total calories.
        //        The total calories are calculated by summing the calories of all the ingredients a Pizza has.
        //        Create the class using a proper constructor, expose a method for adding a topping,
        //        a public setter for the dough, and a getter for the total calories.
        


        private string name;
        private Dough dough;
        private readonly ICollection<Topping> toppings;

        public Pizza(string name, Dough dough):this()
        {
            this.Name = name;
            this.Dough = dough;
           
        }

        private Pizza()
        {
            toppings = new List<Topping>();
        }

        public string Name { get => name; private set 
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException(Exceptions.InvalidPizzaName);
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.InvalidPizzaName);
                }
                name = value;
            } 
        }
        public Dough Dough { get => dough; set => dough = value; }

        public IReadOnlyCollection<Topping> Toppings { get => (IReadOnlyCollection<Topping>)toppings;}
        public double Calories => dough.Calories + ToppingCalories();

        private double ToppingCalories()
        {
            double sum = 0;
            foreach (var topping in toppings)
            {
                sum+=topping.Calories;
            }
            return sum;
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 9)
            {
                throw new ArgumentException(Exceptions.InvalidNumberOfTopping);
            }

            toppings.Add(topping);
        }
    }
}
