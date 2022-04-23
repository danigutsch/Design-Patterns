using DinerMerger.Models;

namespace DinerMerger.Iterators
{
    public class PancakeHouseMenuIterator : IIterator
    {
        private readonly List<MenuItem> _menuItems;
        private int _position;

        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext() => _position < _menuItems.Count;

        public MenuItem Next() => _menuItems[_position++];
    }
}
