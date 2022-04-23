using DinerMerger.Models;

namespace DinerMerger.Iterators
{
    public class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _menuItems;
        private int _position;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext() => _position < _menuItems.Length && _menuItems[_position] is not null;

        public MenuItem Next() => _menuItems[_position++];
    }
}
