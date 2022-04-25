﻿using System.Globalization;

namespace Menu
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool isVegetarian, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
            IsVegetarian = isVegetarian;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override decimal Price { get; }
        public override bool IsVegetarian { get; }

        public override void Print()
        {
            Console.Write(" " + Name);
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + Price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("    --" + Description);
        }
    }
}
