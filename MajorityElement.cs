/*Given an array nums of size n, return the majority element.
The majority element is the element that appears more than [n / 2] times.
You may assume that the majority element always exists in the array.*/

namespace LeetCodeTopInterviw
{
    public class MajorityElement
    {
        public int MajorityElementEasy(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
        }
    }
}
