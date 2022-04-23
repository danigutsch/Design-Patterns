using DinerMerger.Models;
using DinerMerger.Models.Menus;

namespace DinerMerger
{
    public static class Program
    {
        public static void Main()
        {
            PancakeHouseMenu pancakeHouseMenu = new();
            DinerMenu dinerMenu = new();
            Waitress waitress = new(pancakeHouseMenu, dinerMenu);
            waitress.PrintMenu();
        }
    }
}