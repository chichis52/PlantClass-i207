using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSystem
{
    public class Tree : Plant
    {
        public double Height;

        public Tree(string name, double height) : base(name)
        {
            Height = height;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"дерево: {Name}, высота: {Height:F1} см");
        }
    }
}
