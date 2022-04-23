using DinerMerger.Iterators;

namespace DinerMerger.Models.Menus
{
    public interface IMenu
    {
        public IIterator CreateIterator();
    }
}
