using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
