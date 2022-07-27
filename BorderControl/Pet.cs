using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    internal class Pet:IBirthdates
    {

        private string name;
        private string birthDate;

        public Pet(string name, string birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public string Name { get => name; private set => name = value; }
        public string BirthDate { get => birthDate; private set => birthDate = value; }
    }
}
