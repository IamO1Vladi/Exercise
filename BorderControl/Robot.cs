using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    internal class Robot:IIdentifier
    {

        private string model;
        private string id;

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get => model; private set => model = value; }
        public string Id { get => id; private set => id = value; }
    }
}
