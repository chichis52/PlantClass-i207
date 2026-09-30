using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSystem
{
    public class Plant
    {
        public string Name;

        public Plant(string name)
        {
            Name = name;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"название: {Name}");
        }
    }
}
