namespace DinerMergerCafe.Models.Menus
{
    public class CafeMenu : IMenu
    {
        private readonly Dictionary<string, MenuItem> _menuItems = new();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99m);
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69m);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29m);
        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new(name, description, vegetarian, price);
            _menuItems.Add(name, menuItem);
        }

        public IEnumerator<MenuItem> CreateIterator() => _menuItems.Values.GetEnumerator();

        public override string ToString() => "Objectville Café Menu";
    }
}
