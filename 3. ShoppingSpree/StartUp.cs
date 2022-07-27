using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                string[] cmdFirstImput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] cmdSecondImput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            try
            {
                foreach (var person in cmdFirstImput)
                {
                    string name = person.Split("=")[0];
                    decimal money = decimal.Parse(person.Split("=")[1]);

                    Person newPerson = new Person(name, money);
                    people.Add(newPerson);
                }




                foreach (var product in cmdSecondImput)
                {
                    string name = product.Split("=")[0];
                    decimal cost = decimal.Parse(product.Split("=")[1]);

                    Product newProduct = new Product(name, cost);
                    products.Add(newProduct);
                }



                string[] cmdImput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                while (cmdImput[0] != "END")
                {

                    string personName = cmdImput[0];
                    string productWanted = cmdImput[1];

                    Person currentPerson = people.First(x => x.Name == personName);
                    Product currentProduct = products.First(x => x.Name == productWanted);

                    if (currentPerson.Money >= currentProduct.Cost)
                    {
                        currentPerson.Money -= currentProduct.Cost;
                        currentPerson.Products.Add(currentProduct);
                        Console.WriteLine($"{personName} bought {productWanted}");
                    }
                    else
                    {
                        Console.WriteLine($"{personName} can't afford {productWanted}");
                    }
                    cmdImput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }catch(ArgumentException ar)
            {
                Console.WriteLine(ar.Message);
            }
            
        }
    }
}
