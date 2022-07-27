using System;
using System.Linq;

namespace PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The input for a Pizza consists of several lines.
        //On the first line is the Pizza name and on the second line, you will get input for the dough.
        //On the next lines, you will receive every topping the Pizza has.
        //If the creation of the Pizza was successful, print on a single line the name of the Pizza and the total calories it has.
            try
                {

                string pizzaNama = Console.ReadLine().Split(" ")[1];
                string[] cmdImput = Console.ReadLine().Split(" ").ToArray();
                string doughType = cmdImput[1];
                string bakedStyle = cmdImput[2];
                double doughGrams = double.Parse(cmdImput[3]);
                

                Pizza pizza = new Pizza(pizzaNama, new Dough(doughType, bakedStyle, doughGrams));

                cmdImput= Console.ReadLine().Split(" ").ToArray();

                while (cmdImput[0] != "END")
                {
                    Topping currentTopping = new Topping(cmdImput[1], double.Parse(cmdImput[2]));

                    pizza.AddTopping(currentTopping);

                    cmdImput=Console.ReadLine().Split(" ").ToArray();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.Calories:F2} Calories.");
            }
            catch(ArgumentException ar)
            {
                Console.WriteLine(ar.Message);
            }

            

        }
    }
}
