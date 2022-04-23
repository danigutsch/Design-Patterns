using DinerMerger.Models;

namespace DinerMerger.Iterators
{
    public interface IIterator
    {
        bool HasNext();
        MenuItem Next();
    }
}
