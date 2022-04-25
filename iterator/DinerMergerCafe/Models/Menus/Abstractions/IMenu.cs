namespace DinerMergerCafe.Models.Menus
{
    public interface IMenu
    {
        IEnumerator<MenuItem> CreateIterator();
    }
}
