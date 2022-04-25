using System.Globalization;

namespace DinerMergerCafe.Models
{
    public class MenuItem
    {
        public string Name { get; }
        public string Description { get; }
        public bool Vegetarian { get; }
        public decimal Price { get; }

        public MenuItem(string name,
                        string description,
                        bool vegetarian,
                        decimal price)
        {
            Name = name;
            Description = description;
            Vegetarian = vegetarian;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString(CultureInfo.InvariantCulture)} -- {Description}";
        }
    }
}
