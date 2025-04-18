namespace LeetCodeTopInterviw
{
    public class RandomizedSet
    {
        private List<int> set;
        private Random rnd;
        public RandomizedSet()
        {
            set = new List<int>();
            rnd = new Random();
        }

        public bool Insert(int val)
        {
            if (!set.Contains(val))
            {
                set.Add(val);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remove(int val)
        {
            if (set.Contains(val))
            {
                set.Remove(val);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetRandom()
        {
            return set[rnd.Next(0, set.Count)];
        }
    }
}
