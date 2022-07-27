using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    internal class Dough
    {

        //The base ingredient of a Pizza is the dough.First, you need to create a class for it.
        //It has a flour type, which can be white or wholegrain.
        //In addition, it has a baking technique, which can be crispy, chewy, or homemade.
        //The dough should weigh grams.
        //The calories per gram of dough are calculated depending on the flour type and the baking technique.
        //Every dough has 2 calories per gram as a base and a modifier that gives the exact calories.
        //For example, a white dough has a modifier of 1.5, a chewy dough has a modifier of 1.1,
        //which means that a white chewy dough, weighing 100 grams will have (2 * 100) * 1.5 * 1.1 = 330.00 total calories.
        //You are given the modifiers below:
        //Modifiers:	
        //•	White - 1.5
        //•	Wholegrain - 1.0
        //•	Crispy - 0.9
        //•	Chewy - 1.1
        //•	Homemade - 1.0
        //Everything that the class should expose is a getter for the calories per gram.
        //Your task is to create the class with a proper constructor, fields, getters, and setters.
        //Make sure you use the proper access modifiers.

        private string flour;
        private string bakingTechnique;
        private double grams;
        
        private const double defaulthCaloriesPerGram = 2.0;

        private readonly Dictionary<string, double> flourType = new Dictionary<string, double>
        {
            {"white",1.5 },
            {"wholegrain",1.0 },
            
        };

        private readonly Dictionary<string, double> bakingType = new Dictionary<string, double>
        {
            {"crispy",0.9 },
            {"chewy",1.1 },
            {"homemade",1.0 }
        };

        public Dough(string flour, string bakingTechnique,double grams)
        {
            this.Flour = flour;
            this.BakingTechnique = bakingTechnique;
            this.Grams = grams;
        }

        public string Flour { get => flour; private set 
            {
                if (!flourType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(Exceptions.InvalidDoughType);
                }
                flour = value.ToLower();
            } 
        }
        public string BakingTechnique { get => bakingTechnique; private set 
            {
                if (!bakingType.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException(Exceptions.InvalidDoughType);
                }
                bakingTechnique = value.ToLower();
            } 
        }
        public double Calories => (grams * defaulthCaloriesPerGram) * flourType[flour] * bakingType[bakingTechnique];


               
             
        
           

        public double Grams { get => grams; private set 
            { 
                if(value < 1.0 || value > 200.0)
                {
                    throw new ArgumentException(Exceptions.InvalidGramsRange);
                }
                grams = value;
            } 
        }

    }
}
