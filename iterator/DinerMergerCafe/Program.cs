using DinerMergerCafe.Models;
using DinerMergerCafe.Models.Menus;

namespace DinerMerger
{
    public static class Program
    {
        public static void Main()
        {
            PancakeHouseMenu pancakeHouseMenu = new();
            DinerMenu dinerMenu = new();
            CafeMenu cafeMenu = new();
            List<IMenu> menus = new() { pancakeHouseMenu, dinerMenu, cafeMenu };
            Waitress waitress = new(menus);
            waitress.PrintMenu();
        }
    }
}