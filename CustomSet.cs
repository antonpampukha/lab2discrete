namespace lab2
{
    public class CustomSet
    {
        public int CountElemInSubset { get; init; }

        private List<int> set;
        public CustomSet(int CountElemInSet, int CountElemInSubset)
        {
            if (CountElemInSet < 0 || CountElemInSubset < 0)
                throw new Exception("Not correct value");
            if (CountElemInSet < CountElemInSubset)
                throw new Exception("Count element in set less than in subset");

            set = new List<int>() { Capacity = CountElemInSet };
            this.CountElemInSubset = CountElemInSubset;

            for (int i = 0; i < set.Capacity; i++)
            {
                set.Add(i + 1);
            }
        }

        public void ShowSet()
        {
            if (set == null)
                return;
            Console.Write("\nSet:\n{ ");
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
        }
        public void InvokeGenerateAndShowSubsets()
        {
            if (CountElemInSubset == set.Capacity)
            {
                ShowSet();
                return;
            }
            List<int> subset = new List<int>();
            int index = 0;
            Console.Write("\nSubset:");
            GenerateAndShowSubsets(index, subset);
        }

        public void GenerateAndShowSubsets(int index, List<int> subset)
        {
            if (subset.Count == CountElemInSubset)
            {
                Console.Write("\n{" + string.Join(", ", subset) + "}");
                return;
            }

            for (int i = index; i < set.Count; i++)
            {
                subset.Add(set[i]);
                GenerateAndShowSubsets(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
