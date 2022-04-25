using DinerMergerCafe.Models.Menus;

namespace DinerMergerCafe.Models
{
    public class Waitress
    {
        private readonly List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public void PrintMenu()
        {
            IEnumerator<IMenu> menusEnumerator = _menus.GetEnumerator();
            while (menusEnumerator.MoveNext())
            {
                IMenu menu = menusEnumerator.Current;
                PrintMenu(menu.CreateIterator());
            }
        }

        private static void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                Console.WriteLine(menuItem);
            }
            Console.WriteLine();
        }
    }
}
