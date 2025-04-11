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

        public static bool CanJump1(int[] nums)
        {
            int nearestTrue = nums.Length - 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= nearestTrue)
                {
                    nearestTrue = i;
                }
            }

            return nearestTrue == 0;
        }
    }
}
