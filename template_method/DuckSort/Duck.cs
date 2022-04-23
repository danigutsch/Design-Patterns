namespace DuckSort
{
    public class Duck : IComparable<Duck>
    {
        public string Name { get; }
        public int Weight { get; }

        public Duck(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name + " weighs " + Weight;
        }

        public int CompareTo(Duck? otherDuck)
        {
            if (otherDuck == null) return 1;
            return Weight.CompareTo(otherDuck.Weight);
        }
    }
}
