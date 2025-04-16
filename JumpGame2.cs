
namespace LeetCodeTopInterviw
{
    public class JumpGame2
    {
        public static int CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int step = 1;
            int curElIndex = 0;
            int max = 0;
            int maxIndex = 0;
            if (nums[0] >= nums.Length - 1)
            {
                return step;
            }
            for (int i = 1; i <= nums.Length - 2; i++)
            {
                if (i > curElIndex + nums[curElIndex])
                {
                    step++;
                    curElIndex = maxIndex;
                    i = maxIndex;
                    max = 0;
                    maxIndex = 0;
                }
                else if (i - curElIndex + nums[i] >= max)
                {
                    max = i - curElIndex + nums[i];
                    maxIndex = i;
                }

                if (i + nums[i] >= nums.Length - 1)
                {
                    return ++step;
                }
            }

            return step;
        }

        public static int CanJump1(int[] nums)
        {
            int jumps = 0, farthest = 0, end = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Update the farthest point we can reach
                farthest = Math.Max(farthest, i + nums[i]);

                // If we've reached the current end, we need to jump
                if (i == end)
                {
                    jumps++;
                    end = farthest; // Update the range for the next jump
                }
            }

            return jumps;
        }
    }
}
