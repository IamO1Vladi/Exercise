using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    internal class Topping
    {

        //        Next, you need to create a Topping class.
        //        It can be of four different types - meat, veggies, cheese, or a sauce.
        //        A Тopping weights grams.
        //        The calories per gram of topping are calculated depending on its type.
        //        The base calories per gram are 2. Every different type of topping has a modifier.
        //        For example, meat has a modifier of 1.2, so a meat topping will have 1.2 calories per gram (1 * 1.2).
        //        Everything that the class should expose is a getter for calories per gram.You are given the modifiers below:
        //Modifiers:
        //•	Meat - 1.2;
        //•	Veggies - 0.8;
        //•	Cheese - 1.1;
        //•	Sauce - 0.9;
        //Your task is to create the class with a proper constructor, fields, getters, and setters.
        //Make sure you use the proper access modifiers.


        private const double defaulthCaloriesPerGram = 2.0;


        private readonly Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            {"meat",1.2 },
            {"veggies",0.8 },
            {"cheese",1.1 },
            {"sauce",0.9 }

        };

        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            this.Type = type;
            this.Grams = grams;
        }

        public string Type { get => type; private set 
            {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(String.Format(Exceptions.InvalidTopping,value));
                }
                type = value.ToLower();
            } 
        }
        public double Grams { get => grams; private set 
            {
                if (value < 1.0 || value > 50.0)
                {
                    throw new ArgumentException(string.Format(Exceptions.InvalidToppingWeight, char.ToUpper(type[0])+type.Substring(1)));
                }
                grams = value;
            } 
        }

        public double Calories =>(grams*defaulthCaloriesPerGram)*toppingTypes[type];

    }
}
