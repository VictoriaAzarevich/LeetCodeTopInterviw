namespace LeetCodeTopInterviw
{
    public class RotateArray
    {
        static public void RotateArrayMedium1(int[] nums, int k)
        {
            for (int i = 1; i <= k; i++)
            {
                int next = nums[0];
                int previous = 0;
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    previous = next;
                    next = nums[j + 1];
                    nums[j + 1] = previous;
                }
                nums[0] = next;
            }
        }

        public static void RotateArrayMedium2(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1 || nums.Length == k)
                return;

            int s = 0;
            int p = 0;
            int e = nums[p];

            for (int c = 1; c <= nums.Length; c++)
            {
                p = (p + k) % nums.Length;
                (e, nums[p]) = (nums[p], e);

                if (p == s)
                {
                    s++;
                    p++;
                    e = nums[p];
                }
            }
        }
    }
}
