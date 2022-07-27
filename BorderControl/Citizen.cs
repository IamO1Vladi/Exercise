using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    internal class Citizen:IIdentifier,IBirthdates,IBuyer
    {

        private string name;
        private int age;
        private string id;
        private string birthDate;
        private int food;

        public Citizen(string name, int age, string id,string birthDate="0")
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
            this.Food = 0;
        }

        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
        public string Id { get => id; private set => id = value; }
        public string BirthDate { get => birthDate; private set => birthDate = value; }
        public int Food { get => food; private set => food = value; }

        public int BuyFood()
        {
            food += 10;
            return 10;
        }
    }
}
