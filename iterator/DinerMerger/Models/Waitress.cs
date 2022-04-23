using DinerMerger.Iterators;
using DinerMerger.Models.Menus;

namespace DinerMerger.Models
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeHouseIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinerMenu.CreateIterator();

            Console.WriteLine("MENU\n----\nBREAKFAST");
            PrintMenu(pancakeHouseIterator);
            Console.WriteLine("MENU\n----\nLUNCH");
            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = iterator.Next();
                Console.WriteLine(menuItem);
            }
            Console.WriteLine();
        }
    }
}
