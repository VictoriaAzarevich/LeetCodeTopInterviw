namespace LeetCodeTopInterviw
{
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            if (nums.Length == 1)
            {
                return true;
            }

            if (nums[0] == 0)
            {
                return false;
            }

            int indexOfZero = 0;
            int i = 0;

            while (true)
            {
                if (nums[i] + i >= nums.Length - 1)
                {
                    return true;
                }

                if (indexOfZero >= i + nums[i])
                {
                    i--;
                    if (i < 0)
                    {
                        return false;
                    }
                    continue;
                }

                if (nums[i] == 0)
                {
                    indexOfZero = i;
                    i--;
                    continue;
                }

                indexOfZero = 0;
                i += nums[i];
            }
        }
    }
}
