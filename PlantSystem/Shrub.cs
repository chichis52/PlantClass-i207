using System;
using System.Collections.Generic;
using System.Text;

namespace PlantSystem
{
    public class Shrub : Plant
    {
        public int BranchCount;

        public Shrub(string name, int branchCount) : base(name)
        {
            BranchCount = branchCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"куст: {Name}, веток: {BranchCount}");
        }
    }
}
