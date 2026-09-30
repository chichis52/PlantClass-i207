using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSystem
{
    public class Flower : Plant
    {
        public string Color;

        public Flower(string name, string color) : base(name)
        {
            Color = color;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"цветок: {Name}, цвет {Color}");
        }
    }
}
