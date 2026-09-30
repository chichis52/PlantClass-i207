using System;
using PlantSystem;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        var plants = new List<Plant>();
        string repeat;

        do
        {
            repeat = "да";
            Console.WriteLine("выберите тип растения: цветок, дерево или куст");
            string type = Console.ReadLine();

            Plant newPlant = null;

            if (type == "цветок")
            {
                Console.Write("название цветка: ");
                string fName = Console.ReadLine();
                Console.Write("цветом: ");
                string fColor = Console.ReadLine();
                newPlant = new Flower(fName, fColor);
            }
            else if (type == "дерево")
            {
                Console.Write("название дерева: ");
                string tName = Console.ReadLine();
                Console.Write("высотой: ");
                double tHeight = double.Parse(Console.ReadLine());
                newPlant = new Tree(tName, tHeight);
            }
            else if (type == "куст")
            {
                Console.Write("название куста: ");
                string sName = Console.ReadLine();
                Console.Write("с количеством веток: ");
                int sBranches = int.Parse(Console.ReadLine());
                newPlant = new Shrub(sName, sBranches);
            }
            else
            {
                continue;
            }

            
            if (newPlant != null)
            {
                plants.Add(newPlant);
                Console.WriteLine("расстение добавлено");
            }

            Console.Write("хотите добавить ещё одно растение?");
            repeat = Console.ReadLine();

        } while (repeat == "да");

        
        Console.WriteLine("внесённые растения:");
        if (plants.Count >= 1)
        {
            foreach (var p in plants)
            {
                p.ShowInfo();
            }
        }
        
    }
}