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

        /* private List<int> nums;
        private Dictionary<int, int> indexMap;
        private Random rand;
        public RandomizedSet()
        {
            nums = new List<int>();
            indexMap = new Dictionary<int, int>();
            rand = new Random();
        }

        public bool Insert(int val)
        {
            if (indexMap.ContainsKey(val))
            {
                return false;
            }

            nums.Add(val);
            indexMap[val] = nums.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            if (!indexMap.ContainsKey(val))
            {
                return false;
            }

            int lastElement = nums[nums.Count - 1];
            int valIndex = indexMap[val];

            nums[valIndex] = lastElement;
            indexMap[lastElement] = valIndex;

            nums.RemoveAt(nums.Count - 1);
            indexMap.Remove(val);

            return true;
        }

        public int GetRandom()
        {
            int randomIndex = rand.Next(nums.Count);
            return nums[randomIndex];
        } */
    }
}
