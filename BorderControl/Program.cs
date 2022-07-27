using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    internal class Program
    {

        static void BorderControl()
        {
            List<IIdentifier> identifiers = new List<IIdentifier>();

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (cmdArg[0] != "End")
            {

                if (cmdArg.Length > 2)
                {
                    string name = cmdArg[0];
                    int age = int.Parse(cmdArg[1]);
                    string id = cmdArg[2];

                    IIdentifier currentIdentity = new Citizen(name, age, id);
                    identifiers.Add(currentIdentity);
                }
                else
                {
                    string model = cmdArg[0];
                    string id = cmdArg[1];
                    IIdentifier curentIdentity = new Robot(model, id);
                    identifiers.Add(curentIdentity);
                }

                cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string lastDIgits = Console.ReadLine();

            identifiers = identifiers.Where(x => x.Id.Substring(x.Id.Length - lastDIgits.Length) == lastDIgits).ToList();

            foreach (var fakeId in identifiers)
            {
                Console.WriteLine(fakeId.Id);
            }
        }


        static void BirthDayCelebration()
        {
            List<IBirthdates> birthdates = new List<IBirthdates>();

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (cmdArg[0] != "End")
            {

                if (cmdArg[0] == "Citizen")
                {
                    string name = cmdArg[1];
                    int age = int.Parse(cmdArg[2]);
                    string id = cmdArg[3];
                    string date = cmdArg[4];

                    IBirthdates currentCitizen = new Citizen(name, age, id, date);
                    birthdates.Add(currentCitizen);
                }
                else if (cmdArg[0] == "Pet")
                {
                    string name = cmdArg[1];
                    string date = cmdArg[2];
                    IBirthdates currentPet = new Pet(name, date);
                    birthdates.Add(currentPet);
                }

                cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            string year = Console.ReadLine();

            birthdates = birthdates.Where(x => x.BirthDate.Split("/")[2] == year).ToList();

            if (birthdates.Count > 0)
            {
                foreach (var date in birthdates)
                {
                    Console.WriteLine(date.BirthDate);
                }
            }
            else
            {
                Console.WriteLine();
            }
        
    }

        static void Main(string[] args)
        {

            List<IBuyer> buyerList = new List<IBuyer>();
            int boughtFood = 0;

            int numberOfPeople = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberOfPeople; i++)
            {

                string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmdArg.Length > 3)
                {
                    string name = cmdArg[0];
                    int age = int.Parse(cmdArg[1]);
                    string id = cmdArg[2];
                    string date = cmdArg[3];

                    IBuyer buyer=new Citizen(name, age, id, date);
                    buyerList.Add(buyer);
                }
                else
                {
                    string name = cmdArg[0];
                    int age = int.Parse(cmdArg[1]);
                    string group = cmdArg[2];

                    IBuyer buyer=new Rebel(name, age, group);
                    buyerList.Add(buyer);

                }

            }


            string cmdImput;

            while ((cmdImput = Console.ReadLine()) != "End")
            {
                if (buyerList.Any(x=>x.Name==cmdImput))
                {
                    IBuyer buyer = buyerList.First(x => x.Name == cmdImput);
                    boughtFood += buyer.BuyFood();
                }

            }

            Console.WriteLine(boughtFood);
        }
    }
}
